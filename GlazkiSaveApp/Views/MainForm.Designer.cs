namespace GlazkiSaveApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pageNumLbl = new System.Windows.Forms.Label();
            this.prevLbl = new System.Windows.Forms.Label();
            this.pageOneLbl = new System.Windows.Forms.Label();
            this.pageTwoLbl = new System.Windows.Forms.Label();
            this.pageThreeLbl = new System.Windows.Forms.Label();
            this.pageFourLbl = new System.Windows.Forms.Label();
            this.pageNextLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1643, 754);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pageNumLbl
            // 
            this.pageNumLbl.AutoSize = true;
            this.pageNumLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNumLbl.Location = new System.Drawing.Point(783, 921);
            this.pageNumLbl.Name = "pageNumLbl";
            this.pageNumLbl.Size = new System.Drawing.Size(103, 39);
            this.pageNumLbl.TabIndex = 1;
            this.pageNumLbl.Text = "1 / 10";
            // 
            // prevLbl
            // 
            this.prevLbl.AutoSize = true;
            this.prevLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevLbl.Location = new System.Drawing.Point(1360, 925);
            this.prevLbl.Name = "prevLbl";
            this.prevLbl.Size = new System.Drawing.Size(36, 39);
            this.prevLbl.TabIndex = 2;
            this.prevLbl.Text = "<";
            this.prevLbl.Click += new System.EventHandler(this.prevLbl_Click);
            // 
            // pageOneLbl
            // 
            this.pageOneLbl.AutoSize = true;
            this.pageOneLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOneLbl.Location = new System.Drawing.Point(1402, 925);
            this.pageOneLbl.Name = "pageOneLbl";
            this.pageOneLbl.Size = new System.Drawing.Size(35, 39);
            this.pageOneLbl.TabIndex = 2;
            this.pageOneLbl.Text = "1";
            // 
            // pageTwoLbl
            // 
            this.pageTwoLbl.AutoSize = true;
            this.pageTwoLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTwoLbl.Location = new System.Drawing.Point(1441, 925);
            this.pageTwoLbl.Name = "pageTwoLbl";
            this.pageTwoLbl.Size = new System.Drawing.Size(35, 39);
            this.pageTwoLbl.TabIndex = 2;
            this.pageTwoLbl.Text = "2";
            // 
            // pageThreeLbl
            // 
            this.pageThreeLbl.AutoSize = true;
            this.pageThreeLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageThreeLbl.Location = new System.Drawing.Point(1482, 925);
            this.pageThreeLbl.Name = "pageThreeLbl";
            this.pageThreeLbl.Size = new System.Drawing.Size(35, 39);
            this.pageThreeLbl.TabIndex = 2;
            this.pageThreeLbl.Text = "3";
            // 
            // pageFourLbl
            // 
            this.pageFourLbl.AutoSize = true;
            this.pageFourLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageFourLbl.Location = new System.Drawing.Point(1523, 925);
            this.pageFourLbl.Name = "pageFourLbl";
            this.pageFourLbl.Size = new System.Drawing.Size(35, 39);
            this.pageFourLbl.TabIndex = 2;
            this.pageFourLbl.Text = "4";
            // 
            // pageNextLbl
            // 
            this.pageNextLbl.AutoSize = true;
            this.pageNextLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNextLbl.Location = new System.Drawing.Point(1564, 925);
            this.pageNextLbl.Name = "pageNextLbl";
            this.pageNextLbl.Size = new System.Drawing.Size(36, 39);
            this.pageNextLbl.TabIndex = 2;
            this.pageNextLbl.Text = ">";
            this.pageNextLbl.Click += new System.EventHandler(this.pageNextLbl_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 1005);
            this.Controls.Add(this.pageNextLbl);
            this.Controls.Add(this.pageFourLbl);
            this.Controls.Add(this.pageThreeLbl);
            this.Controls.Add(this.pageTwoLbl);
            this.Controls.Add(this.pageOneLbl);
            this.Controls.Add(this.prevLbl);
            this.Controls.Add(this.pageNumLbl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label pageNumLbl;
        private System.Windows.Forms.Label prevLbl;
        private System.Windows.Forms.Label pageOneLbl;
        private System.Windows.Forms.Label pageTwoLbl;
        private System.Windows.Forms.Label pageThreeLbl;
        private System.Windows.Forms.Label pageFourLbl;
        private System.Windows.Forms.Label pageNextLbl;
    }
}

