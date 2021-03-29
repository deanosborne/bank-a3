namespace a3.Forms
{
    partial class AllCustomer
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sfDataGrid_cm = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.managectab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cm_deleteBtn = new System.Windows.Forms.Button();
            this.cm_searchTxt = new System.Windows.Forms.TextBox();
            this.cm_updateBtn = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cm_idbox = new System.Windows.Forms.TextBox();
            this.cm_phoneBox = new System.Windows.Forms.TextBox();
            this.cm_nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cm_emailBox = new System.Windows.Forms.TextBox();
            this.manageatab = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.ma_balBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.sfDataGrid_ma = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.ma_deleteBtn = new System.Windows.Forms.Button();
            this.ma_interestBox = new System.Windows.Forms.TextBox();
            this.ma_updateBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ma_typeBox = new System.Windows.Forms.TextBox();
            this.ma_searchBox = new System.Windows.Forms.TextBox();
            this.ma_feeBox = new System.Windows.Forms.TextBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.ma_nameBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.attab = new System.Windows.Forms.TabPage();
            this.at_balanceBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.at_clearBtn = new System.Windows.Forms.Button();
            this.at_amountBox = new System.Windows.Forms.TextBox();
            this.at_updateBtn = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.at_transactiontypeCombo = new System.Windows.Forms.ComboBox();
            this.at_typeBox = new System.Windows.Forms.TextBox();
            this.at_nameBox = new System.Windows.Forms.TextBox();
            this.at_outputBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.addctab = new System.Windows.Forms.TabPage();
            this.newcust_clearBtn = new System.Windows.Forms.Button();
            this.newcust_staffFalse = new System.Windows.Forms.RadioButton();
            this.newcust_comfirmBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.newcust_staffTrue = new System.Windows.Forms.RadioButton();
            this.newcust_nameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newcust_phoneBox = new System.Windows.Forms.TextBox();
            this.newcust_emailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addatab = new System.Windows.Forms.TabPage();
            this.newacc_clearBtn = new System.Windows.Forms.Button();
            this.newacc_updateBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.newacc_interestBox = new System.Windows.Forms.TextBox();
            this.newacc_typeBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.newacc_feeBox = new System.Windows.Forms.TextBox();
            this.newacc_nameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid_cm)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.managectab.SuspendLayout();
            this.manageatab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid_ma)).BeginInit();
            this.attab.SuspendLayout();
            this.addctab.SuspendLayout();
            this.addatab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid_cm
            // 
            this.sfDataGrid_cm.AccessibleName = "Table";
            this.sfDataGrid_cm.Location = new System.Drawing.Point(12, 77);
            this.sfDataGrid_cm.Name = "sfDataGrid_cm";
            this.sfDataGrid_cm.Size = new System.Drawing.Size(521, 327);
            this.sfDataGrid_cm.TabIndex = 12;
            this.sfDataGrid_cm.Text = "sfDataGrid1";
            this.sfDataGrid_cm.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.SfDataGrid_cm_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.managectab);
            this.tabControl1.Controls.Add(this.manageatab);
            this.tabControl1.Controls.Add(this.attab);
            this.tabControl1.Controls.Add(this.addctab);
            this.tabControl1.Controls.Add(this.addatab);
            this.tabControl1.Location = new System.Drawing.Point(19, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 483);
            this.tabControl1.TabIndex = 16;
            // 
            // managectab
            // 
            this.managectab.Controls.Add(this.label1);
            this.managectab.Controls.Add(this.cm_deleteBtn);
            this.managectab.Controls.Add(this.cm_searchTxt);
            this.managectab.Controls.Add(this.cm_updateBtn);
            this.managectab.Controls.Add(this.radioButton2);
            this.managectab.Controls.Add(this.radioButton1);
            this.managectab.Controls.Add(this.sfDataGrid_cm);
            this.managectab.Controls.Add(this.label3);
            this.managectab.Controls.Add(this.label4);
            this.managectab.Controls.Add(this.label6);
            this.managectab.Controls.Add(this.cm_idbox);
            this.managectab.Controls.Add(this.cm_phoneBox);
            this.managectab.Controls.Add(this.cm_nameBox);
            this.managectab.Controls.Add(this.label5);
            this.managectab.Controls.Add(this.label2);
            this.managectab.Controls.Add(this.cm_emailBox);
            this.managectab.Location = new System.Drawing.Point(4, 22);
            this.managectab.Name = "managectab";
            this.managectab.Padding = new System.Windows.Forms.Padding(3);
            this.managectab.Size = new System.Drawing.Size(817, 457);
            this.managectab.TabIndex = 1;
            this.managectab.Text = "Customer Search & Manage";
            this.managectab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Search";
            // 
            // cm_deleteBtn
            // 
            this.cm_deleteBtn.Location = new System.Drawing.Point(703, 381);
            this.cm_deleteBtn.Name = "cm_deleteBtn";
            this.cm_deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.cm_deleteBtn.TabIndex = 42;
            this.cm_deleteBtn.Text = "Delete";
            this.cm_deleteBtn.UseVisualStyleBackColor = true;
            // 
            // cm_searchTxt
            // 
            this.cm_searchTxt.Location = new System.Drawing.Point(57, 50);
            this.cm_searchTxt.Name = "cm_searchTxt";
            this.cm_searchTxt.Size = new System.Drawing.Size(298, 20);
            this.cm_searchTxt.TabIndex = 62;
            this.cm_searchTxt.TextChanged += new System.EventHandler(this.cm_searchTxt_TextChanged);
            // 
            // cm_updateBtn
            // 
            this.cm_updateBtn.Location = new System.Drawing.Point(609, 381);
            this.cm_updateBtn.Name = "cm_updateBtn";
            this.cm_updateBtn.Size = new System.Drawing.Size(75, 23);
            this.cm_updateBtn.TabIndex = 41;
            this.cm_updateBtn.Text = "Update";
            this.cm_updateBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(608, 318);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(559, 318);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Staff:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Name:";
            // 
            // cm_idbox
            // 
            this.cm_idbox.Enabled = false;
            this.cm_idbox.Location = new System.Drawing.Point(559, 93);
            this.cm_idbox.Name = "cm_idbox";
            this.cm_idbox.Size = new System.Drawing.Size(238, 20);
            this.cm_idbox.TabIndex = 31;
            // 
            // cm_phoneBox
            // 
            this.cm_phoneBox.Location = new System.Drawing.Point(559, 259);
            this.cm_phoneBox.Name = "cm_phoneBox";
            this.cm_phoneBox.Size = new System.Drawing.Size(238, 20);
            this.cm_phoneBox.TabIndex = 37;
            // 
            // cm_nameBox
            // 
            this.cm_nameBox.Location = new System.Drawing.Point(559, 153);
            this.cm_nameBox.Name = "cm_nameBox";
            this.cm_nameBox.Size = new System.Drawing.Size(238, 20);
            this.cm_nameBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Phone:";
            // 
            // cm_emailBox
            // 
            this.cm_emailBox.Location = new System.Drawing.Point(559, 208);
            this.cm_emailBox.Name = "cm_emailBox";
            this.cm_emailBox.Size = new System.Drawing.Size(238, 20);
            this.cm_emailBox.TabIndex = 35;
            // 
            // manageatab
            // 
            this.manageatab.Controls.Add(this.label21);
            this.manageatab.Controls.Add(this.ma_balBox);
            this.manageatab.Controls.Add(this.comboBox3);
            this.manageatab.Controls.Add(this.sfDataGrid_ma);
            this.manageatab.Controls.Add(this.ma_deleteBtn);
            this.manageatab.Controls.Add(this.ma_interestBox);
            this.manageatab.Controls.Add(this.ma_updateBtn);
            this.manageatab.Controls.Add(this.label20);
            this.manageatab.Controls.Add(this.radioButton5);
            this.manageatab.Controls.Add(this.label19);
            this.manageatab.Controls.Add(this.label15);
            this.manageatab.Controls.Add(this.ma_typeBox);
            this.manageatab.Controls.Add(this.ma_searchBox);
            this.manageatab.Controls.Add(this.ma_feeBox);
            this.manageatab.Controls.Add(this.radioButton6);
            this.manageatab.Controls.Add(this.ma_nameBox);
            this.manageatab.Controls.Add(this.label18);
            this.manageatab.Controls.Add(this.label16);
            this.manageatab.Controls.Add(this.label17);
            this.manageatab.Location = new System.Drawing.Point(4, 22);
            this.manageatab.Name = "manageatab";
            this.manageatab.Padding = new System.Windows.Forms.Padding(3);
            this.manageatab.Size = new System.Drawing.Size(817, 457);
            this.manageatab.TabIndex = 2;
            this.manageatab.Text = "Manage Account";
            this.manageatab.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(539, 284);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 13);
            this.label21.TabIndex = 61;
            this.label21.Text = "Current Balance:";
            // 
            // ma_balBox
            // 
            this.ma_balBox.Location = new System.Drawing.Point(542, 300);
            this.ma_balBox.Name = "ma_balBox";
            this.ma_balBox.Size = new System.Drawing.Size(238, 20);
            this.ma_balBox.TabIndex = 62;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(81, 44);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(122, 21);
            this.comboBox3.TabIndex = 60;
            // 
            // sfDataGrid_ma
            // 
            this.sfDataGrid_ma.AccessibleName = "Table";
            this.sfDataGrid_ma.Location = new System.Drawing.Point(37, 70);
            this.sfDataGrid_ma.Name = "sfDataGrid_ma";
            this.sfDataGrid_ma.Size = new System.Drawing.Size(470, 327);
            this.sfDataGrid_ma.TabIndex = 46;
            this.sfDataGrid_ma.Text = "sfDataGrid2";
            // 
            // ma_deleteBtn
            // 
            this.ma_deleteBtn.Location = new System.Drawing.Point(705, 374);
            this.ma_deleteBtn.Name = "ma_deleteBtn";
            this.ma_deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.ma_deleteBtn.TabIndex = 59;
            this.ma_deleteBtn.Text = "Delete";
            this.ma_deleteBtn.UseVisualStyleBackColor = true;
            // 
            // ma_interestBox
            // 
            this.ma_interestBox.Location = new System.Drawing.Point(542, 201);
            this.ma_interestBox.Name = "ma_interestBox";
            this.ma_interestBox.Size = new System.Drawing.Size(238, 20);
            this.ma_interestBox.TabIndex = 52;
            // 
            // ma_updateBtn
            // 
            this.ma_updateBtn.Location = new System.Drawing.Point(611, 374);
            this.ma_updateBtn.Name = "ma_updateBtn";
            this.ma_updateBtn.Size = new System.Drawing.Size(75, 23);
            this.ma_updateBtn.TabIndex = 58;
            this.ma_updateBtn.Text = "Update";
            this.ma_updateBtn.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(539, 236);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Fee rate:";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(594, 349);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(39, 17);
            this.radioButton5.TabIndex = 57;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "No";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(539, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "Interest Rate:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Search";
            // 
            // ma_typeBox
            // 
            this.ma_typeBox.Location = new System.Drawing.Point(542, 146);
            this.ma_typeBox.Name = "ma_typeBox";
            this.ma_typeBox.Size = new System.Drawing.Size(238, 20);
            this.ma_typeBox.TabIndex = 47;
            // 
            // ma_searchBox
            // 
            this.ma_searchBox.Location = new System.Drawing.Point(209, 44);
            this.ma_searchBox.Name = "ma_searchBox";
            this.ma_searchBox.Size = new System.Drawing.Size(298, 20);
            this.ma_searchBox.TabIndex = 45;
            // 
            // ma_feeBox
            // 
            this.ma_feeBox.Location = new System.Drawing.Point(542, 252);
            this.ma_feeBox.Name = "ma_feeBox";
            this.ma_feeBox.Size = new System.Drawing.Size(238, 20);
            this.ma_feeBox.TabIndex = 54;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(545, 349);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(43, 17);
            this.radioButton6.TabIndex = 56;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Yes";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // ma_nameBox
            // 
            this.ma_nameBox.Enabled = false;
            this.ma_nameBox.Location = new System.Drawing.Point(542, 86);
            this.ma_nameBox.Name = "ma_nameBox";
            this.ma_nameBox.Size = new System.Drawing.Size(238, 20);
            this.ma_nameBox.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(539, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Account Type:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(539, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Customer Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(545, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Staff:";
            // 
            // attab
            // 
            this.attab.Controls.Add(this.at_balanceBox);
            this.attab.Controls.Add(this.label26);
            this.attab.Controls.Add(this.at_clearBtn);
            this.attab.Controls.Add(this.at_amountBox);
            this.attab.Controls.Add(this.at_updateBtn);
            this.attab.Controls.Add(this.label25);
            this.attab.Controls.Add(this.label24);
            this.attab.Controls.Add(this.at_transactiontypeCombo);
            this.attab.Controls.Add(this.at_typeBox);
            this.attab.Controls.Add(this.at_nameBox);
            this.attab.Controls.Add(this.at_outputBox);
            this.attab.Controls.Add(this.label22);
            this.attab.Controls.Add(this.label23);
            this.attab.Location = new System.Drawing.Point(4, 22);
            this.attab.Name = "attab";
            this.attab.Size = new System.Drawing.Size(817, 457);
            this.attab.TabIndex = 4;
            this.attab.Text = "Account Transactions";
            this.attab.UseVisualStyleBackColor = true;
            // 
            // at_balanceBox
            // 
            this.at_balanceBox.Location = new System.Drawing.Point(528, 313);
            this.at_balanceBox.Name = "at_balanceBox";
            this.at_balanceBox.Size = new System.Drawing.Size(238, 20);
            this.at_balanceBox.TabIndex = 62;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(525, 297);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 13);
            this.label26.TabIndex = 63;
            this.label26.Text = "Current Balance:";
            // 
            // at_clearBtn
            // 
            this.at_clearBtn.Location = new System.Drawing.Point(691, 354);
            this.at_clearBtn.Name = "at_clearBtn";
            this.at_clearBtn.Size = new System.Drawing.Size(75, 23);
            this.at_clearBtn.TabIndex = 61;
            this.at_clearBtn.Text = "Clear";
            this.at_clearBtn.UseVisualStyleBackColor = true;
            // 
            // at_amountBox
            // 
            this.at_amountBox.Location = new System.Drawing.Point(528, 237);
            this.at_amountBox.Name = "at_amountBox";
            this.at_amountBox.Size = new System.Drawing.Size(238, 20);
            this.at_amountBox.TabIndex = 57;
            // 
            // at_updateBtn
            // 
            this.at_updateBtn.Location = new System.Drawing.Point(610, 354);
            this.at_updateBtn.Name = "at_updateBtn";
            this.at_updateBtn.Size = new System.Drawing.Size(75, 23);
            this.at_updateBtn.TabIndex = 60;
            this.at_updateBtn.Text = "Update";
            this.at_updateBtn.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(525, 221);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "Amount:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(525, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 13);
            this.label24.TabIndex = 56;
            this.label24.Text = "Transaction Type:";
            // 
            // at_transactiontypeCombo
            // 
            this.at_transactiontypeCombo.FormattingEnabled = true;
            this.at_transactiontypeCombo.Location = new System.Drawing.Point(528, 181);
            this.at_transactiontypeCombo.Name = "at_transactiontypeCombo";
            this.at_transactiontypeCombo.Size = new System.Drawing.Size(238, 21);
            this.at_transactiontypeCombo.TabIndex = 55;
            // 
            // at_typeBox
            // 
            this.at_typeBox.Location = new System.Drawing.Point(528, 125);
            this.at_typeBox.Name = "at_typeBox";
            this.at_typeBox.Size = new System.Drawing.Size(238, 20);
            this.at_typeBox.TabIndex = 51;
            // 
            // at_nameBox
            // 
            this.at_nameBox.Enabled = false;
            this.at_nameBox.Location = new System.Drawing.Point(528, 65);
            this.at_nameBox.Name = "at_nameBox";
            this.at_nameBox.Size = new System.Drawing.Size(238, 20);
            this.at_nameBox.TabIndex = 52;
            // 
            // at_outputBox
            // 
            this.at_outputBox.Location = new System.Drawing.Point(16, 49);
            this.at_outputBox.Multiline = true;
            this.at_outputBox.Name = "at_outputBox";
            this.at_outputBox.Size = new System.Drawing.Size(492, 328);
            this.at_outputBox.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(525, 109);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 53;
            this.label22.Text = "Account Type:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(525, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 13);
            this.label23.TabIndex = 54;
            this.label23.Text = "Customer Name:";
            // 
            // addctab
            // 
            this.addctab.Controls.Add(this.newcust_clearBtn);
            this.addctab.Controls.Add(this.newcust_staffFalse);
            this.addctab.Controls.Add(this.newcust_comfirmBtn);
            this.addctab.Controls.Add(this.label10);
            this.addctab.Controls.Add(this.newcust_staffTrue);
            this.addctab.Controls.Add(this.newcust_nameBox);
            this.addctab.Controls.Add(this.label7);
            this.addctab.Controls.Add(this.label9);
            this.addctab.Controls.Add(this.newcust_phoneBox);
            this.addctab.Controls.Add(this.newcust_emailBox);
            this.addctab.Controls.Add(this.label8);
            this.addctab.Location = new System.Drawing.Point(4, 22);
            this.addctab.Name = "addctab";
            this.addctab.Padding = new System.Windows.Forms.Padding(3);
            this.addctab.Size = new System.Drawing.Size(817, 457);
            this.addctab.TabIndex = 0;
            this.addctab.Text = "New Customer";
            this.addctab.UseVisualStyleBackColor = true;
            // 
            // newcust_clearBtn
            // 
            this.newcust_clearBtn.Location = new System.Drawing.Point(417, 346);
            this.newcust_clearBtn.Name = "newcust_clearBtn";
            this.newcust_clearBtn.Size = new System.Drawing.Size(97, 23);
            this.newcust_clearBtn.TabIndex = 28;
            this.newcust_clearBtn.Text = "Clear";
            this.newcust_clearBtn.UseVisualStyleBackColor = true;
            // 
            // newcust_staffFalse
            // 
            this.newcust_staffFalse.AutoSize = true;
            this.newcust_staffFalse.Location = new System.Drawing.Point(325, 278);
            this.newcust_staffFalse.Name = "newcust_staffFalse";
            this.newcust_staffFalse.Size = new System.Drawing.Size(39, 17);
            this.newcust_staffFalse.TabIndex = 27;
            this.newcust_staffFalse.TabStop = true;
            this.newcust_staffFalse.Text = "No";
            this.newcust_staffFalse.UseVisualStyleBackColor = true;
            // 
            // newcust_comfirmBtn
            // 
            this.newcust_comfirmBtn.Location = new System.Drawing.Point(417, 307);
            this.newcust_comfirmBtn.Name = "newcust_comfirmBtn";
            this.newcust_comfirmBtn.Size = new System.Drawing.Size(97, 23);
            this.newcust_comfirmBtn.TabIndex = 21;
            this.newcust_comfirmBtn.Text = "Confirm";
            this.newcust_comfirmBtn.UseVisualStyleBackColor = true;
            this.newcust_comfirmBtn.Click += new System.EventHandler(this.newcust_comfirmBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Name:";
            // 
            // newcust_staffTrue
            // 
            this.newcust_staffTrue.AutoSize = true;
            this.newcust_staffTrue.Location = new System.Drawing.Point(276, 278);
            this.newcust_staffTrue.Name = "newcust_staffTrue";
            this.newcust_staffTrue.Size = new System.Drawing.Size(43, 17);
            this.newcust_staffTrue.TabIndex = 26;
            this.newcust_staffTrue.TabStop = true;
            this.newcust_staffTrue.Text = "Yes";
            this.newcust_staffTrue.UseVisualStyleBackColor = true;
            // 
            // newcust_nameBox
            // 
            this.newcust_nameBox.Location = new System.Drawing.Point(276, 117);
            this.newcust_nameBox.Name = "newcust_nameBox";
            this.newcust_nameBox.Size = new System.Drawing.Size(238, 20);
            this.newcust_nameBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Staff:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Email:";
            // 
            // newcust_phoneBox
            // 
            this.newcust_phoneBox.Location = new System.Drawing.Point(276, 219);
            this.newcust_phoneBox.Name = "newcust_phoneBox";
            this.newcust_phoneBox.Size = new System.Drawing.Size(238, 20);
            this.newcust_phoneBox.TabIndex = 24;
            // 
            // newcust_emailBox
            // 
            this.newcust_emailBox.Location = new System.Drawing.Point(276, 168);
            this.newcust_emailBox.Name = "newcust_emailBox";
            this.newcust_emailBox.Size = new System.Drawing.Size(238, 20);
            this.newcust_emailBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Phone:";
            // 
            // addatab
            // 
            this.addatab.Controls.Add(this.newacc_clearBtn);
            this.addatab.Controls.Add(this.newacc_updateBtn);
            this.addatab.Controls.Add(this.label14);
            this.addatab.Controls.Add(this.newacc_interestBox);
            this.addatab.Controls.Add(this.newacc_typeBox);
            this.addatab.Controls.Add(this.label11);
            this.addatab.Controls.Add(this.label13);
            this.addatab.Controls.Add(this.newacc_feeBox);
            this.addatab.Controls.Add(this.newacc_nameBox);
            this.addatab.Controls.Add(this.label12);
            this.addatab.Location = new System.Drawing.Point(4, 22);
            this.addatab.Name = "addatab";
            this.addatab.Size = new System.Drawing.Size(817, 457);
            this.addatab.TabIndex = 3;
            this.addatab.Text = "New Account";
            this.addatab.UseVisualStyleBackColor = true;
            // 
            // newacc_clearBtn
            // 
            this.newacc_clearBtn.Location = new System.Drawing.Point(429, 347);
            this.newacc_clearBtn.Name = "newacc_clearBtn";
            this.newacc_clearBtn.Size = new System.Drawing.Size(97, 23);
            this.newacc_clearBtn.TabIndex = 42;
            this.newacc_clearBtn.Text = "Clear";
            this.newacc_clearBtn.UseVisualStyleBackColor = true;
            // 
            // newacc_updateBtn
            // 
            this.newacc_updateBtn.Location = new System.Drawing.Point(429, 309);
            this.newacc_updateBtn.Name = "newacc_updateBtn";
            this.newacc_updateBtn.Size = new System.Drawing.Size(97, 23);
            this.newacc_updateBtn.TabIndex = 41;
            this.newacc_updateBtn.Text = "Confirm";
            this.newacc_updateBtn.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(285, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Account Type:";
            // 
            // newacc_interestBox
            // 
            this.newacc_interestBox.Enabled = false;
            this.newacc_interestBox.Location = new System.Drawing.Point(288, 259);
            this.newacc_interestBox.Name = "newacc_interestBox";
            this.newacc_interestBox.Size = new System.Drawing.Size(238, 20);
            this.newacc_interestBox.TabIndex = 40;
            // 
            // newacc_typeBox
            // 
            this.newacc_typeBox.FormattingEnabled = true;
            this.newacc_typeBox.Location = new System.Drawing.Point(288, 100);
            this.newacc_typeBox.Name = "newacc_typeBox";
            this.newacc_typeBox.Size = new System.Drawing.Size(238, 21);
            this.newacc_typeBox.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Interest rate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(285, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Customer Name:";
            // 
            // newacc_feeBox
            // 
            this.newacc_feeBox.Enabled = false;
            this.newacc_feeBox.Location = new System.Drawing.Point(288, 206);
            this.newacc_feeBox.Name = "newacc_feeBox";
            this.newacc_feeBox.Size = new System.Drawing.Size(238, 20);
            this.newacc_feeBox.TabIndex = 38;
            // 
            // newacc_nameBox
            // 
            this.newacc_nameBox.Enabled = false;
            this.newacc_nameBox.Location = new System.Drawing.Point(288, 155);
            this.newacc_nameBox.Name = "newacc_nameBox";
            this.newacc_nameBox.Size = new System.Drawing.Size(238, 20);
            this.newacc_nameBox.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Failed fee:";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(a3.Models.Customer);
            // 
            // AllCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "AllCustomer";
            this.Text = "AllCustomer";
            this.Load += new System.EventHandler(this.AllCustomer_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid_cm)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.managectab.ResumeLayout(false);
            this.managectab.PerformLayout();
            this.manageatab.ResumeLayout(false);
            this.manageatab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid_ma)).EndInit();
            this.attab.ResumeLayout(false);
            this.attab.PerformLayout();
            this.addctab.ResumeLayout(false);
            this.addctab.PerformLayout();
            this.addatab.ResumeLayout(false);
            this.addatab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid_cm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addctab;
        private System.Windows.Forms.TabPage managectab;
        private System.Windows.Forms.Button cm_deleteBtn;
        private System.Windows.Forms.Button cm_updateBtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox cm_idbox;
        private System.Windows.Forms.TextBox cm_phoneBox;
        public System.Windows.Forms.TextBox cm_nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cm_emailBox;
        private System.Windows.Forms.RadioButton newcust_staffFalse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton newcust_staffTrue;
        private System.Windows.Forms.TextBox newcust_nameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newcust_phoneBox;
        private System.Windows.Forms.TextBox newcust_emailBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button newcust_comfirmBtn;
        private System.Windows.Forms.TabPage manageatab;
        private System.Windows.Forms.TabPage addatab;
        private System.Windows.Forms.ComboBox comboBox3;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid_ma;
        private System.Windows.Forms.Button ma_deleteBtn;
        private System.Windows.Forms.TextBox ma_interestBox;
        private System.Windows.Forms.Button ma_updateBtn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox ma_typeBox;
        private System.Windows.Forms.TextBox ma_searchBox;
        private System.Windows.Forms.TextBox ma_feeBox;
        private System.Windows.Forms.RadioButton radioButton6;
        public System.Windows.Forms.TextBox ma_nameBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button newcust_clearBtn;
        private System.Windows.Forms.Button newacc_clearBtn;
        private System.Windows.Forms.Button newacc_updateBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox newacc_interestBox;
        private System.Windows.Forms.ComboBox newacc_typeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox newacc_feeBox;
        private System.Windows.Forms.TextBox newacc_nameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox ma_balBox;
        private System.Windows.Forms.TabPage attab;
        public System.Windows.Forms.TextBox at_amountBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox at_transactiontypeCombo;
        public System.Windows.Forms.TextBox at_typeBox;
        public System.Windows.Forms.TextBox at_nameBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox at_balanceBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button at_clearBtn;
        private System.Windows.Forms.Button at_updateBtn;
        public System.Windows.Forms.TextBox at_outputBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cm_searchTxt;
    }
}