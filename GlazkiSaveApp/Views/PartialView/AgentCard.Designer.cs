namespace GlazkiSaveApp.Views.PartialView
{
    partial class AgentCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeNameLbl = new System.Windows.Forms.Label();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.percentLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.priorityValueLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // typeNameLbl
            // 
            this.typeNameLbl.AutoSize = true;
            this.typeNameLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeNameLbl.Location = new System.Drawing.Point(460, 39);
            this.typeNameLbl.Name = "typeNameLbl";
            this.typeNameLbl.Size = new System.Drawing.Size(586, 47);
            this.typeNameLbl.TabIndex = 1;
            this.typeNameLbl.Text = "Тип | Наименование агента";
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLbl.Location = new System.Drawing.Point(462, 104);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(366, 49);
            this.qtyLbl.TabIndex = 1;
            this.qtyLbl.Text = "10 продаж за год";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(462, 168);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(334, 49);
            this.phoneLbl.TabIndex = 1;
            this.phoneLbl.Text = "+7 800 876 54 43";
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLbl.Location = new System.Drawing.Point(462, 272);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(356, 49);
            this.priorityLbl.TabIndex = 1;
            this.priorityLbl.Text = "Приоритетность:";
            // 
            // percentLbl
            // 
            this.percentLbl.AutoSize = true;
            this.percentLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLbl.Location = new System.Drawing.Point(1356, 39);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(98, 47);
            this.percentLbl.TabIndex = 1;
            this.percentLbl.Text = "10%";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1565, 16);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlazkiSaveApp.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(74, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // priorityValueLbl
            // 
            this.priorityValueLbl.AutoSize = true;
            this.priorityValueLbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityValueLbl.Location = new System.Drawing.Point(824, 272);
            this.priorityValueLbl.Name = "priorityValueLbl";
            this.priorityValueLbl.Size = new System.Drawing.Size(66, 49);
            this.priorityValueLbl.TabIndex = 1;
            this.priorityValueLbl.Text = "32";
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.priorityValueLbl);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.qtyLbl);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.typeNameLbl);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(1565, 358);
            this.Load += new System.EventHandler(this.AgentCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label typeNameLbl;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.Label percentLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label priorityLbl;
        public System.Windows.Forms.Label phoneLbl;
        public System.Windows.Forms.Label priorityValueLbl;
    }
}
