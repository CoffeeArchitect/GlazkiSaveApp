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
    }
}
