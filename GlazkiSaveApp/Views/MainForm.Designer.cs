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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pageNumLbl = new System.Windows.Forms.Label();
            this.prevLbl = new System.Windows.Forms.Label();
            this.pageOneLbl = new System.Windows.Forms.Label();
            this.pageTwoLbl = new System.Windows.Forms.Label();
            this.pageThreeLbl = new System.Windows.Forms.Label();
            this.pageFourLbl = new System.Windows.Forms.Label();
            this.pageNextLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1268, 792);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pageNumLbl
            // 
            this.pageNumLbl.AutoSize = true;
            this.pageNumLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNumLbl.Location = new System.Drawing.Point(605, 967);
            this.pageNumLbl.Name = "pageNumLbl";
            this.pageNumLbl.Size = new System.Drawing.Size(103, 39);
            this.pageNumLbl.TabIndex = 1;
            this.pageNumLbl.Text = "1 / 10";
            // 
            // prevLbl
            // 
            this.prevLbl.AutoSize = true;
            this.prevLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevLbl.Location = new System.Drawing.Point(1021, 967);
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
            this.pageOneLbl.Location = new System.Drawing.Point(1068, 967);
            this.pageOneLbl.Name = "pageOneLbl";
            this.pageOneLbl.Size = new System.Drawing.Size(35, 39);
            this.pageOneLbl.TabIndex = 2;
            this.pageOneLbl.Text = "1";
            // 
            // pageTwoLbl
            // 
            this.pageTwoLbl.AutoSize = true;
            this.pageTwoLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTwoLbl.Location = new System.Drawing.Point(1111, 967);
            this.pageTwoLbl.Name = "pageTwoLbl";
            this.pageTwoLbl.Size = new System.Drawing.Size(35, 39);
            this.pageTwoLbl.TabIndex = 2;
            this.pageTwoLbl.Text = "2";
            // 
            // pageThreeLbl
            // 
            this.pageThreeLbl.AutoSize = true;
            this.pageThreeLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageThreeLbl.Location = new System.Drawing.Point(1157, 967);
            this.pageThreeLbl.Name = "pageThreeLbl";
            this.pageThreeLbl.Size = new System.Drawing.Size(35, 39);
            this.pageThreeLbl.TabIndex = 2;
            this.pageThreeLbl.Text = "3";
            // 
            // pageFourLbl
            // 
            this.pageFourLbl.AutoSize = true;
            this.pageFourLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageFourLbl.Location = new System.Drawing.Point(1202, 967);
            this.pageFourLbl.Name = "pageFourLbl";
            this.pageFourLbl.Size = new System.Drawing.Size(35, 39);
            this.pageFourLbl.TabIndex = 2;
            this.pageFourLbl.Text = "4";
            // 
            // pageNextLbl
            // 
            this.pageNextLbl.AutoSize = true;
            this.pageNextLbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNextLbl.Location = new System.Drawing.Point(1248, 967);
            this.pageNextLbl.Name = "pageNextLbl";
            this.pageNextLbl.Size = new System.Drawing.Size(36, 39);
            this.pageNextLbl.TabIndex = 2;
            this.pageNextLbl.Text = ">";
            this.pageNextLbl.Click += new System.EventHandler(this.pageNextLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlazkiSaveApp.Properties.Resources.Глазки_save;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(139, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(383, 47);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.Text = "Введите для поиска";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Наименоание",
            "Приоритет"});
            this.sortComboBox.Location = new System.Drawing.Point(528, 47);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(256, 47);
            this.sortComboBox.TabIndex = 5;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(1038, 47);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(227, 47);
            this.filterComboBox.TabIndex = 5;
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descCheckBox.Location = new System.Drawing.Point(790, 49);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(242, 43);
            this.descCheckBox.TabIndex = 6;
            this.descCheckBox.Text = "По убыанию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.descCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 958);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Изменить приоритет на ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1295, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descCheckBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pageNextLbl);
            this.Controls.Add(this.pageFourLbl);
            this.Controls.Add(this.pageThreeLbl);
            this.Controls.Add(this.pageTwoLbl);
            this.Controls.Add(this.pageOneLbl);
            this.Controls.Add(this.prevLbl);
            this.Controls.Add(this.pageNumLbl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Глазки-Save";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        public System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.Button button1;
    }
}

