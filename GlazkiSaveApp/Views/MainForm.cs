using GlazkiSaveApp.Models;
using GlazkiSaveApp.Utils;
using GlazkiSaveApp.Views;
using GlazkiSaveApp.Views.PartialView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazkiSaveApp
{
    public partial class MainForm : Form
    {
        public static List<Agent> agents = new List<Agent>();
        public static List<AgentCard> selectedAgentCard = new List<AgentCard>();
        int currentPage = 0;
        int currentSize = 20;
        // Счётчик страниц
        int pageNum = 0;
        int pageSize = 20;
        public MainForm()
        {
            InitializeComponent();
            agents = DatabaseContext.db.Agent.ToList();
            TurnPageOnMainForm(currentPage, currentSize);
            
        }

        private void GenerateAgentCardList(List<Agent> agent)
        {
            foreach (var a in agent)
            {
                
                AgentCard card = new AgentCard();
                
                card.GenerateDataToAgentCard(a);
                flowLayoutPanel1.Controls.Add(card);
                
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
                card.Click += new System.EventHandler(this.Card_Click);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;
            
             
            if (card.BackColor == Color.White)
            {
                card.BackColor = Color.FromArgb(255, 233, 249);
                selectedAgentCard.Add(card);
            }
            else
            {
                card.BackColor = Color.White;
                selectedAgentCard.Remove(card);
            }
            
            if (selectedAgentCard.Count > 1)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;
            selectedAgentCard.Add(card);
            EditAgentForm editForm = new EditAgentForm();
            DialogResult dialogResult = editForm.ShowDialog();
            
        }
        
        /// <summary>
        /// Filter, Search And Sort
        /// </summary>
        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Agent.ToList();

            #region Filter
            if (filterComboBox.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.AgentType.Title == filterComboBox.SelectedItem.ToString())
                    .ToList();
            }
            #endregion

            #region Search
            if (searchTextBox.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                listUpdate = listUpdate
                    .Where(p => p.Title.ToLower().Contains(searchTextBox.Text.ToLower())
                    || p.Phone.Contains(searchTextBox.Text)
                    || p.Email.ToLower().Contains(searchTextBox.Text.ToLower()))
                    .ToList();
            }
            #endregion

            #region Sort
            if (sortComboBox.Text == "Наименование")
            {
                if (!descCheckBox.Checked)
                    listUpdate = listUpdate.OrderBy(p => p.Title).ToList();
                else
                    listUpdate = listUpdate.
                        OrderByDescending(p => p.Title).ToList();
            }
            if (sortComboBox.Text == "Приоритет")
            {
                if (!descCheckBox.Checked)
                    listUpdate = listUpdate.OrderBy(p => p.Priority).ToList();
                else
                    listUpdate = listUpdate.
                        OrderByDescending(p => p.Priority).ToList();

            }
            flowLayoutPanel1.Controls.Clear();


            #endregion
            
            GenerateAgentCardList(listUpdate);
        }

        private void TurnPageOnMainForm(int pN, int pS)
        {
            if (currentPage < 0)
            {
                currentPage = 0;
                pageNum = 0;
            }

            pageNumLbl.Text = (pageNum + 1) + "/" + (int)(agents.Count / pageSize);
            var pageList = agents.Skip(pageNum * pageSize).Take(pageSize).ToList();
            GenerateAgentCardList(pageList);
        }

        private void pageNextLbl_Click(object sender, EventArgs e)
        {
            if (pageNum > 3)
                return;
            pageNum++;
            currentPage = ((currentPage + 1) * currentSize) < agents.Count() ? (currentPage + 1) : currentPage;
            flowLayoutPanel1.Controls.Clear();
            TurnPageOnMainForm(currentPage, currentSize);
        }

        private void prevLbl_Click(object sender, EventArgs e)
        {
            if (pageNum < 1)
                return;
            pageNum--;
            currentPage = (currentPage - currentSize) < 0 ? (currentPage - 1) : 0;
            flowLayoutPanel1.Controls.Clear();
            TurnPageOnMainForm(currentPage, currentSize);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "Введите для поиска")
            {
                flowLayoutPanel1.Controls.Clear();
                SortListView();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.AgentType.Select(type => type.Title).ToList();
            allType.Insert(0, "Все типы");
            filterComboBox.DataSource = allType;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
            
            
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PriorityChangeModalWindow priorityChange = new PriorityChangeModalWindow();
            DialogResult dialogResult = priorityChange.ShowDialog();
            SortListView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SortListView();
        }
    }
}
