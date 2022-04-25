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

namespace GlazkiSaveApp.Views
{
    public partial class PriorityChangeModalWindow : Form
    {
        public PriorityChangeModalWindow()
        {
            InitializeComponent();
        }

        private void PriorityChangeModalWindow_Load(object sender, EventArgs e)
        {
            int max = 0;
            foreach (AgentCard a in MainForm.selectedAgentCard)
            {
                int priority = Convert.ToInt32(a.priorityValueLbl.Text);
                if (priority > max)
                {
                    max = priority;
                }

            }
            textBox1.Text = max.ToString();
        }

        void GetMaxPriority(AgentCard agentCards)
        {

            textBox1.Text = agentCards.priorityLbl.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valueTxtBox = Convert.ToInt32(textBox1.Text);
            foreach (AgentCard agentCard in MainForm.selectedAgentCard)
            {
                Agent agent = (DatabaseContext.db.Agent.First(x => x.Phone == agentCard.phoneLbl.Text)) as Agent;
                agent.Priority += valueTxtBox;
            }

            try
            {
                DatabaseContext.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
