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
    }
}
