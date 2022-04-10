using GlazkiSaveApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazkiSaveApp.Views.PartialView
{
    public partial class AgentCard : UserControl
    {
        
        public AgentCard()
        {
            InitializeComponent();
        }

        public void GenerateDataToAgentCard(Agent agent)
        {
            pictureBox1.ImageLocation = agent.Logo;
            typeNameLbl.Text = agent.AgentType.Title + " | " + agent.Title;
            int qty = 0;
            decimal sum = 0;
            foreach (ProductSale sale in agent.ProductSale)
            {
                qty =+ sale.ProductCount;
                sum =+ qty * sale.Product.MinCostForAgent;
            }

            qtyLbl.Text = qty + " продаж за год";
            phoneLbl.Text = agent.Phone;
            priorityLbl.Text = "Приоритетность: " + agent.Priority;
            
            if (sum < 10000)
            {
                percentLbl.Text = "0%";
            }
            else if (sum >= 10000 && sum <= 50000)
            {
                percentLbl.Text = "5%";
            }
            else if (sum > 50000 && sum <= 150000)
            {
                percentLbl.Text = "10%";
            }
            else if (sum > 150000 && sum <= 500000)
            {
                percentLbl.Text = "20%";
            }
            else
            {
                percentLbl.Text = "25%";
            }
        }
    }
}
