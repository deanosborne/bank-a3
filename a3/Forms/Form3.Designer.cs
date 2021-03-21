namespace a3
{
    partial class Form3
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
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.controllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(79, 295);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(420, 20);
            this.customer_name.TabIndex = 3;
            this.customer_name.MouseHover += new System.EventHandler(this.customer_name_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // controllerBindingSource
            // 
            this.controllerBindingSource.DataSource = typeof(a3.Controller);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(79, 332);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(128, 23);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            this.add_btn.MouseHover += new System.EventHandler(this.add_btn_MouseHover);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(79, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 154);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Account Number";
            this.columnHeader2.Width = 97;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(225, 332);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(128, 23);
            this.edit_btn.TabIndex = 13;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            this.edit_btn.MouseHover += new System.EventHandler(this.edit_btn_MouseHover);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(371, 332);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(128, 23);
            this.remove_btn.TabIndex = 14;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            this.remove_btn.MouseHover += new System.EventHandler(this.remove_btn_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_name);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.customer_name, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.add_btn, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.edit_btn, 0);
            this.Controls.SetChildIndex(this.remove_btn, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.controllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.BindingSource controllerBindingSource;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}