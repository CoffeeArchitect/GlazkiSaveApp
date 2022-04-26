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
    public partial class EditAgentForm : Form
    {
        public Agent Agent { get; set; } = null;
        public EditAgentForm()
        {
            InitializeComponent();
        }

        private void EditAgentForm_Load(object sender, EventArgs e)
        {

            foreach (AgentCard agentCard in MainForm.selectedAgentCard)
            {
                Agent agent = (DatabaseContext.db.Agent.First(x => x.Phone == agentCard.phoneLbl.Text)) as Agent;
                agentBindingSource.DataSource = agent;
                pictureBox1.ImageLocation = agent.Logo;
            }
        }

       

        private void changeImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "";
            dialog.InitialDirectory = Environment.CurrentDirectory;
            dialog.InitialDirectory += @"\agents\";
            
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string file = dialog.FileName;
                int num = file.IndexOf("agents");
                file = file.Substring(num);

                pictureBox1.Image = Image.FromFile(file);
                ((Agent)agentBindingSource.Current).Logo = file;
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Agent = (Agent)agentBindingSource.Current;
            DatabaseContext.db.Agent.Add(Agent);

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
