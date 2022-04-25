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

namespace GlazkiSaveApp.Views
{
    public partial class EditAgentForm : Form
    {
        public Agent Agent { get; set; } = null;
        public EditAgentForm()
        {
            InitializeComponent();
        }
    }
}
