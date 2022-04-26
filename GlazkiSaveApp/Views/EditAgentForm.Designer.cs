namespace GlazkiSaveApp.Views
{
    partial class EditAgentForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label titleLabel1;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeImgBtn = new System.Windows.Forms.Button();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            addressLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(13, 46);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(79, 22);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адрес:";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Location = new System.Drawing.Point(13, 83);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(108, 22);
            directorNameLabel.TabIndex = 3;
            directorNameLabel.Text = "Директор:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 120);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(61, 22);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(13, 157);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(55, 22);
            iNNLabel.TabIndex = 7;
            iNNLabel.Text = "ИНН:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Location = new System.Drawing.Point(13, 194);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(52, 22);
            kPPLabel.TabIndex = 9;
            kPPLabel.Text = "КПП:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(13, 231);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(101, 22);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Телефон:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(13, 268);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(116, 22);
            priorityLabel.TabIndex = 15;
            priorityLabel.Text = "Приоритет:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(13, 305);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(106, 22);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "Название:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(13, 342);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(46, 22);
            titleLabel1.TabIndex = 19;
            titleLabel1.Text = "Тип:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(167, 43);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(410, 31);
            this.addressTextBox.TabIndex = 2;
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "DirectorName", true));
            this.directorNameTextBox.Location = new System.Drawing.Point(167, 80);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(410, 31);
            this.directorNameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(167, 117);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(410, 31);
            this.emailTextBox.TabIndex = 6;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(167, 154);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(410, 31);
            this.iNNTextBox.TabIndex = 8;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Location = new System.Drawing.Point(167, 191);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(410, 31);
            this.kPPTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(167, 228);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(410, 31);
            this.phoneTextBox.TabIndex = 14;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox.Location = new System.Drawing.Point(167, 265);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(410, 31);
            this.priorityTextBox.TabIndex = 16;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(167, 302);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(410, 31);
            this.titleTextBox.TabIndex = 18;
            // 
            // titleTextBox1
            // 
            this.titleTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgentType.Title", true));
            this.titleTextBox1.Location = new System.Drawing.Point(167, 339);
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.Size = new System.Drawing.Size(410, 31);
            this.titleTextBox1.TabIndex = 20;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(167, 429);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 33);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Изменить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlazkiSaveApp.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(594, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // changeImgBtn
            // 
            this.changeImgBtn.Location = new System.Drawing.Point(643, 200);
            this.changeImgBtn.Name = "changeImgBtn";
            this.changeImgBtn.Size = new System.Drawing.Size(113, 33);
            this.changeImgBtn.TabIndex = 21;
            this.changeImgBtn.Text = "Изменить";
            this.changeImgBtn.UseVisualStyleBackColor = true;
            this.changeImgBtn.Click += new System.EventHandler(this.changeImgBtn_Click);
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(GlazkiSaveApp.Models.Agent);
            // 
            // EditAgentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1203, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.changeImgBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(titleLabel1);
            this.Controls.Add(this.titleTextBox1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(directorNameLabel);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "EditAgentForm";
            this.Text = "Редактирование агента";
            this.Load += new System.EventHandler(this.EditAgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button changeImgBtn;
    }
}