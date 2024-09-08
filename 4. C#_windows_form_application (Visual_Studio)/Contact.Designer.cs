namespace Store_management_system
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passward_box = new System.Windows.Forms.TextBox();
            this.company_num = new System.Windows.Forms.TextBox();
            this.message_box = new System.Windows.Forms.RichTextBox();
            this.Submit = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(204, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passward";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(204, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passward_box
            // 
            this.passward_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passward_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passward_box.Location = new System.Drawing.Point(531, 340);
            this.passward_box.Name = "passward_box";
            this.passward_box.Size = new System.Drawing.Size(358, 30);
            this.passward_box.TabIndex = 8;
            this.passward_box.UseSystemPasswordChar = true;
            // 
            // company_num
            // 
            this.company_num.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.company_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_num.Location = new System.Drawing.Point(531, 251);
            this.company_num.Name = "company_num";
            this.company_num.Size = new System.Drawing.Size(358, 30);
            this.company_num.TabIndex = 7;
            // 
            // message_box
            // 
            this.message_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.message_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.message_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_box.Location = new System.Drawing.Point(209, 435);
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(680, 323);
            this.message_box.TabIndex = 9;
            this.message_box.Text = "Type Your Message Here";
            this.message_box.UseWaitCursor = true;
//            this.message_box.TextChanged += new System.EventHandler(this.message_box_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Submit.Location = new System.Drawing.Point(422, 814);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(215, 39);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_close.Location = new System.Drawing.Point(674, 814);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(215, 39);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 921);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.passward_box);
            this.Controls.Add(this.company_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Contact";
            this.Text = "Contact";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passward_box;
        private System.Windows.Forms.TextBox company_num;
        private System.Windows.Forms.RichTextBox message_box;
        private System.Windows.Forms.Label Submit;
        private System.Windows.Forms.Label btn_close;
    }
}