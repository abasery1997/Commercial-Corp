namespace Corp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateWar = new System.Windows.Forms.Button();
            this.btnInsertWar = new System.Windows.Forms.Button();
            this.txtWarManager = new System.Windows.Forms.TextBox();
            this.txtWarName = new System.Windows.Forms.TextBox();
            this.txtWarID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxWars = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInsertUnite = new System.Windows.Forms.Button();
            this.txtUniteID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUniteName = new System.Windows.Forms.TextBox();
            this.Unite = new System.Windows.Forms.Label();
            this.lboxItems = new System.Windows.Forms.ListBox();
            this.cboxUnites = new System.Windows.Forms.ComboBox();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.btnItemInsert = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnDemand = new System.Windows.Forms.Button();
            this.btnSupply = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateWar);
            this.groupBox1.Controls.Add(this.btnInsertWar);
            this.groupBox1.Controls.Add(this.txtWarManager);
            this.groupBox1.Controls.Add(this.txtWarName);
            this.groupBox1.Controls.Add(this.txtWarID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboxWars);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 363);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdateWar
            // 
            this.btnUpdateWar.Location = new System.Drawing.Point(196, 261);
            this.btnUpdateWar.Name = "btnUpdateWar";
            this.btnUpdateWar.Size = new System.Drawing.Size(98, 43);
            this.btnUpdateWar.TabIndex = 19;
            this.btnUpdateWar.Text = "Update By ID";
            this.btnUpdateWar.UseVisualStyleBackColor = true;
            this.btnUpdateWar.Click += new System.EventHandler(this.btnUpdateWar_Click);
            // 
            // btnInsertWar
            // 
            this.btnInsertWar.Location = new System.Drawing.Point(71, 261);
            this.btnInsertWar.Name = "btnInsertWar";
            this.btnInsertWar.Size = new System.Drawing.Size(98, 43);
            this.btnInsertWar.TabIndex = 18;
            this.btnInsertWar.Text = "Insert";
            this.btnInsertWar.UseVisualStyleBackColor = true;
            this.btnInsertWar.Click += new System.EventHandler(this.btnInsertWar_Click);
            // 
            // txtWarManager
            // 
            this.txtWarManager.Location = new System.Drawing.Point(267, 174);
            this.txtWarManager.Name = "txtWarManager";
            this.txtWarManager.Size = new System.Drawing.Size(100, 20);
            this.txtWarManager.TabIndex = 17;
            // 
            // txtWarName
            // 
            this.txtWarName.Location = new System.Drawing.Point(136, 174);
            this.txtWarName.Name = "txtWarName";
            this.txtWarName.Size = new System.Drawing.Size(100, 20);
            this.txtWarName.TabIndex = 16;
            // 
            // txtWarID
            // 
            this.txtWarID.Location = new System.Drawing.Point(18, 174);
            this.txtWarID.Name = "txtWarID";
            this.txtWarID.Size = new System.Drawing.Size(100, 20);
            this.txtWarID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // cboxWars
            // 
            this.cboxWars.FormattingEnabled = true;
            this.cboxWars.Location = new System.Drawing.Point(170, 40);
            this.cboxWars.Name = "cboxWars";
            this.cboxWars.Size = new System.Drawing.Size(173, 21);
            this.cboxWars.TabIndex = 6;
            this.cboxWars.SelectedIndexChanged += new System.EventHandler(this.cboxWars_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Warhouses :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fugaz One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Commercial Corp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnInsertUnite);
            this.groupBox2.Controls.Add(this.txtUniteID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtUniteName);
            this.groupBox2.Controls.Add(this.Unite);
            this.groupBox2.Controls.Add(this.lboxItems);
            this.groupBox2.Controls.Add(this.cboxUnites);
            this.groupBox2.Controls.Add(this.btnItemUpdate);
            this.groupBox2.Controls.Add(this.btnItemInsert);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.txtItemCode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(406, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 363);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(260, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Measure Unites";
            // 
            // btnInsertUnite
            // 
            this.btnInsertUnite.Location = new System.Drawing.Point(277, 147);
            this.btnInsertUnite.Name = "btnInsertUnite";
            this.btnInsertUnite.Size = new System.Drawing.Size(75, 23);
            this.btnInsertUnite.TabIndex = 30;
            this.btnInsertUnite.TabStop = false;
            this.btnInsertUnite.Text = "Insert";
            this.btnInsertUnite.Click += new System.EventHandler(this.btnInsertUnite_Click);
            // 
            // txtUniteID
            // 
            this.txtUniteID.Location = new System.Drawing.Point(310, 66);
            this.txtUniteID.Name = "txtUniteID";
            this.txtUniteID.Size = new System.Drawing.Size(57, 20);
            this.txtUniteID.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtUniteName
            // 
            this.txtUniteName.Location = new System.Drawing.Point(310, 103);
            this.txtUniteName.Name = "txtUniteName";
            this.txtUniteName.Size = new System.Drawing.Size(57, 20);
            this.txtUniteName.TabIndex = 25;
            // 
            // Unite
            // 
            this.Unite.AutoSize = true;
            this.Unite.Location = new System.Drawing.Point(260, 106);
            this.Unite.Name = "Unite";
            this.Unite.Size = new System.Drawing.Size(32, 13);
            this.Unite.TabIndex = 24;
            this.Unite.Text = "Unite";
            // 
            // lboxItems
            // 
            this.lboxItems.FormattingEnabled = true;
            this.lboxItems.Location = new System.Drawing.Point(6, 19);
            this.lboxItems.Name = "lboxItems";
            this.lboxItems.Size = new System.Drawing.Size(248, 186);
            this.lboxItems.TabIndex = 21;
            // 
            // cboxUnites
            // 
            this.cboxUnites.FormattingEnabled = true;
            this.cboxUnites.Location = new System.Drawing.Point(253, 250);
            this.cboxUnites.Name = "cboxUnites";
            this.cboxUnites.Size = new System.Drawing.Size(114, 21);
            this.cboxUnites.TabIndex = 20;
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.Location = new System.Drawing.Point(209, 301);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(98, 43);
            this.btnItemUpdate.TabIndex = 19;
            this.btnItemUpdate.Text = "Update Name";
            this.btnItemUpdate.UseVisualStyleBackColor = true;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            // 
            // btnItemInsert
            // 
            this.btnItemInsert.Location = new System.Drawing.Point(38, 301);
            this.btnItemInsert.Name = "btnItemInsert";
            this.btnItemInsert.Size = new System.Drawing.Size(97, 43);
            this.btnItemInsert.TabIndex = 31;
            this.btnItemInsert.Text = "Insert";
            this.btnItemInsert.Click += new System.EventHandler(this.btnItemInsert_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(131, 251);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 16;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(13, 251);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 20);
            this.txtItemCode.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Measure Unite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Code";
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustomers.Location = new System.Drawing.Point(148, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(101, 27);
            this.btnCustomers.TabIndex = 21;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuppliers.Location = new System.Drawing.Point(255, 2);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(101, 27);
            this.btnSuppliers.TabIndex = 21;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnDemand
            // 
            this.btnDemand.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDemand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDemand.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDemand.Location = new System.Drawing.Point(362, 2);
            this.btnDemand.Name = "btnDemand";
            this.btnDemand.Size = new System.Drawing.Size(101, 27);
            this.btnDemand.TabIndex = 21;
            this.btnDemand.Text = "Demand";
            this.btnDemand.UseVisualStyleBackColor = false;
            // 
            // btnSupply
            // 
            this.btnSupply.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSupply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupply.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupply.Location = new System.Drawing.Point(469, 2);
            this.btnSupply.Name = "btnSupply";
            this.btnSupply.Size = new System.Drawing.Size(101, 27);
            this.btnSupply.TabIndex = 21;
            this.btnSupply.Text = "Supply";
            this.btnSupply.UseVisualStyleBackColor = false;
            this.btnSupply.Click += new System.EventHandler(this.btnSupply_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransfer.Location = new System.Drawing.Point(576, 2);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(101, 27);
            this.btnTransfer.TabIndex = 21;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnSupply);
            this.Controls.Add(this.btnDemand);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateWar;
        private System.Windows.Forms.Button btnInsertWar;
        private System.Windows.Forms.TextBox txtWarManager;
        private System.Windows.Forms.TextBox txtWarName;
        private System.Windows.Forms.TextBox txtWarID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxWars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lboxItems;
        private System.Windows.Forms.ComboBox cboxUnites;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.Button btnItemInsert;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInsertUnite;
        private System.Windows.Forms.TextBox txtUniteID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUniteName;
        private System.Windows.Forms.Label Unite;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnDemand;
        private System.Windows.Forms.Button btnSupply;
        private System.Windows.Forms.Button btnTransfer;
    }
}

