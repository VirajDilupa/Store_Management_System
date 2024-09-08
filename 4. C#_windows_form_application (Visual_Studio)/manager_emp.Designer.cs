namespace Store_management_system
{
    partial class manager_emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_emp));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show_emp = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.clear2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.dataGridView.Location = new System.Drawing.Point(32, 131);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(989, 522);
            this.dataGridView.TabIndex = 6;
            // 
            // col1
            // 
            this.col1.HeaderText = "Company_Number";
            this.col1.MinimumWidth = 6;
            this.col1.Name = "col1";
            this.col1.Width = 125;
            // 
            // col2
            // 
            this.col2.HeaderText = "First_Name";
            this.col2.MinimumWidth = 6;
            this.col2.Name = "col2";
            this.col2.Width = 125;
            // 
            // col3
            // 
            this.col3.HeaderText = "Last_Name";
            this.col3.MinimumWidth = 6;
            this.col3.Name = "col3";
            this.col3.Width = 125;
            // 
            // col4
            // 
            this.col4.HeaderText = "Contact_Number";
            this.col4.MinimumWidth = 6;
            this.col4.Name = "col4";
            this.col4.Width = 125;
            // 
            // col5
            // 
            this.col5.HeaderText = "Passward";
            this.col5.MinimumWidth = 6;
            this.col5.Name = "col5";
            this.col5.Width = 125;
            // 
            // show_emp
            // 
            this.show_emp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_emp.Location = new System.Drawing.Point(327, 51);
            this.show_emp.Name = "show_emp";
            this.show_emp.Size = new System.Drawing.Size(345, 50);
            this.show_emp.TabIndex = 5;
            this.show_emp.Text = "Employees Data";
            this.show_emp.UseVisualStyleBackColor = false;
            this.show_emp.Click += new System.EventHandler(this.show_emp_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1377, 603);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(265, 50);
            this.close.TabIndex = 11;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(1086, 603);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(265, 50);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // clear2
            // 
            this.clear2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear2.Location = new System.Drawing.Point(682, 705);
            this.clear2.Name = "clear2";
            this.clear2.Size = new System.Drawing.Size(339, 50);
            this.clear2.TabIndex = 14;
            this.clear2.Text = "Clear Database";
            this.clear2.UseVisualStyleBackColor = false;
            this.clear2.Click += new System.EventHandler(this.clear2_Click);
            // 
            // manager_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1760, 851);
            this.Controls.Add(this.clear2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.show_emp);
            this.Name = "manager_emp";
            this.Text = "manager_emp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.Button show_emp;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button clear2;
    }
}