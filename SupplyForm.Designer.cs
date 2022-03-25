namespace Corp
{
    partial class SupplyForm
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
            this.listBoxSupplayItems = new System.Windows.Forms.ListBox();
            this.cboxWars = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxSupplyID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertSupply = new System.Windows.Forms.Button();
            this.txtSupplyID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxSuppliers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePickerSupplayDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemsNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSupplayItems
            // 
            this.listBoxSupplayItems.FormattingEnabled = true;
            this.listBoxSupplayItems.Location = new System.Drawing.Point(343, 12);
            this.listBoxSupplayItems.Name = "listBoxSupplayItems";
            this.listBoxSupplayItems.Size = new System.Drawing.Size(445, 420);
            this.listBoxSupplayItems.TabIndex = 22;
            // 
            // cboxWars
            // 
            this.cboxWars.FormattingEnabled = true;
            this.cboxWars.Location = new System.Drawing.Point(92, 28);
            this.cboxWars.Name = "cboxWars";
            this.cboxWars.Size = new System.Drawing.Size(173, 21);
            this.cboxWars.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Warhouses :";
            // 
            // cboxSupplyID
            // 
            this.cboxSupplyID.FormattingEnabled = true;
            this.cboxSupplyID.Location = new System.Drawing.Point(92, 74);
            this.cboxSupplyID.Name = "cboxSupplyID";
            this.cboxSupplyID.Size = new System.Drawing.Size(173, 21);
            this.cboxSupplyID.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Supply ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItemsNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DatePickerSupplayDate);
            this.groupBox1.Controls.Add(this.cboxSuppliers);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnInsertSupply);
            this.groupBox1.Controls.Add(this.txtSupplyID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 319);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supply Data";
            // 
            // btnInsertSupply
            // 
            this.btnInsertSupply.Location = new System.Drawing.Point(80, 270);
            this.btnInsertSupply.Name = "btnInsertSupply";
            this.btnInsertSupply.Size = new System.Drawing.Size(98, 43);
            this.btnInsertSupply.TabIndex = 18;
            this.btnInsertSupply.Text = "Insert";
            this.btnInsertSupply.UseVisualStyleBackColor = true;
            this.btnInsertSupply.Click += new System.EventHandler(this.btnInsertSupply_Click);
            // 
            // txtSupplyID
            // 
            this.txtSupplyID.Location = new System.Drawing.Point(114, 50);
            this.txtSupplyID.Name = "txtSupplyID";
            this.txtSupplyID.Size = new System.Drawing.Size(139, 20);
            this.txtSupplyID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID :";
            // 
            // cboxSuppliers
            // 
            this.cboxSuppliers.FormattingEnabled = true;
            this.cboxSuppliers.Location = new System.Drawing.Point(114, 105);
            this.cboxSuppliers.Name = "cboxSuppliers";
            this.cboxSuppliers.Size = new System.Drawing.Size(139, 21);
            this.cboxSuppliers.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Supplier :";
            // 
            // DatePickerSupplayDate
            // 
            this.DatePickerSupplayDate.Location = new System.Drawing.Point(99, 160);
            this.DatePickerSupplayDate.Name = "DatePickerSupplayDate";
            this.DatePickerSupplayDate.Size = new System.Drawing.Size(181, 20);
            this.DatePickerSupplayDate.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Supply Date :";
            // 
            // txtItemsNum
            // 
            this.txtItemsNum.Location = new System.Drawing.Point(144, 212);
            this.txtItemsNum.Name = "txtItemsNum";
            this.txtItemsNum.Size = new System.Drawing.Size(64, 20);
            this.txtItemsNum.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Items Number :";
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboxSupplyID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxWars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxSupplayItems);
            this.Name = "SupplyForm";
            this.Text = "SupplyForm";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSupplayItems;
        private System.Windows.Forms.ComboBox cboxWars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxSupplyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DatePickerSupplayDate;
        private System.Windows.Forms.ComboBox cboxSuppliers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertSupply;
        private System.Windows.Forms.TextBox txtSupplyID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemsNum;
        private System.Windows.Forms.Label label5;
    }
}