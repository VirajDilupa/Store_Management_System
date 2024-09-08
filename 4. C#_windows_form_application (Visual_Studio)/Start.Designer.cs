namespace Store_management_system
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.company_num = new System.Windows.Forms.TextBox();
            this.passward = new System.Windows.Forms.TextBox();
            this.date_time = new System.Windows.Forms.TextBox();
            this.Project_Timer = new System.Windows.Forms.Timer(this.components);
            this.contact = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(381, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1165, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Store Management System!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(320, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(319, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passward";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_login.Location = new System.Drawing.Point(741, 766);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(133, 58);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_clear.Location = new System.Drawing.Point(907, 766);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 58);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // company_num
            // 
            this.company_num.BackColor = System.Drawing.SystemColors.Info;
            this.company_num.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_num.Location = new System.Drawing.Point(741, 566);
            this.company_num.Name = "company_num";
            this.company_num.Size = new System.Drawing.Size(481, 39);
            this.company_num.TabIndex = 5;
            // 
            // passward
            // 
            this.passward.BackColor = System.Drawing.SystemColors.Info;
            this.passward.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passward.Location = new System.Drawing.Point(741, 639);
            this.passward.Name = "passward";
            this.passward.Size = new System.Drawing.Size(481, 43);
            this.passward.TabIndex = 6;
            this.passward.UseSystemPasswordChar = true;
            // 
            // date_time
            // 
            this.date_time.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.date_time.Location = new System.Drawing.Point(12, 12);
            this.date_time.Name = "date_time";
            this.date_time.ReadOnly = true;
            this.date_time.Size = new System.Drawing.Size(299, 27);
            this.date_time.TabIndex = 7;
            this.date_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Project_Timer
            // 
            this.Project_Timer.Enabled = true;
            this.Project_Timer.Tick += new System.EventHandler(this.Project_Timer_Tick);
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.SystemColors.GrayText;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.contact.Location = new System.Drawing.Point(1075, 766);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(147, 58);
            this.contact.TabIndex = 8;
            this.contact.Text = "Contact";
            this.contact.UseVisualStyleBackColor = false;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 903);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "©2024_E2245267_All Rights Reserved.";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1843, 1026);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.passward);
            this.Controls.Add(this.company_num);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox company_num;
        private System.Windows.Forms.TextBox passward;
        private System.Windows.Forms.TextBox date_time;
        private System.Windows.Forms.Timer Project_Timer;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Label label4;
    }
}