using GlazkiSaveApp.Models;
using GlazkiSaveApp.Utils;
using GlazkiSaveApp.Views.PartialView;
using System;
using System.Collections.Generic;
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
        List<Agent> agents = new List<Agent>();
        int currentPage = 0;
        int currentSize = 20;
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
            }
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
                    .Where(type => type.AgentTypeID == (filterComboBox.SelectedItem as AgentType).ID)
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
            #endregion
            GenerateAgentCardList(listUpdate);
        }
        
        private void TurnPageOnMainForm(int pagenum, int pagesize)
        {
            if (currentPage < 0)
            {
                currentPage = 0;
                pagenum = 0;
            }

            pageNumLbl.Text = (pagenum + 1) + "/" + (int)(agents.Count / pagesize);
            var agentsInPage = agents.Skip(pagenum * pagesize).Take(pagesize).ToList();
            GenerateAgentCardList(agentsInPage);
        }

        private void pageNextLbl_Click(object sender, EventArgs e)
        {
            currentPage = ((currentPage + 1) * currentSize) < agents.Count() ? (currentPage + 1) : currentPage;
            flowLayoutPanel1.Controls.Clear();
            TurnPageOnMainForm(currentPage, currentSize);
        }

        private void prevLbl_Click(object sender, EventArgs e)
        {
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
    }
}
