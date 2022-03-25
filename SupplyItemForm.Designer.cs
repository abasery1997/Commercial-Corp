namespace Corp
{
    partial class SupplyItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelWarhouseName = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.txtSuppItemCount = new System.Windows.Forms.TextBox();
            this.datePickerProduction = new System.Windows.Forms.DateTimePicker();
            this.datePickerExpiry = new System.Windows.Forms.DateTimePicker();
            this.btnInsertSuppItem = new System.Windows.Forms.Button();
            this.cboxItems = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warhouse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suppliers :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quentity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Production Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expiry :";
            // 
            // LabelWarhouseName
            // 
            this.LabelWarhouseName.AutoSize = true;
            this.LabelWarhouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWarhouseName.Location = new System.Drawing.Point(120, 25);
            this.LabelWarhouseName.Name = "LabelWarhouseName";
            this.LabelWarhouseName.Size = new System.Drawing.Size(57, 20);
            this.LabelWarhouseName.TabIndex = 6;
            this.LabelWarhouseName.Text = "label7";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.Location = new System.Drawing.Point(558, 17);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(66, 24);
            this.labelSupplierName.TabIndex = 7;
            this.labelSupplierName.Text = "label8";
            // 
            // txtSuppItemCount
            // 
            this.txtSuppItemCount.Location = new System.Drawing.Point(240, 104);
            this.txtSuppItemCount.Name = "txtSuppItemCount";
            this.txtSuppItemCount.Size = new System.Drawing.Size(100, 20);
            this.txtSuppItemCount.TabIndex = 9;
            // 
            // datePickerProduction
            // 
            this.datePickerProduction.Location = new System.Drawing.Point(370, 105);
            this.datePickerProduction.Name = "datePickerProduction";
            this.datePickerProduction.Size = new System.Drawing.Size(200, 20);
            this.datePickerProduction.TabIndex = 10;
            // 
            // datePickerExpiry
            // 
            this.datePickerExpiry.Location = new System.Drawing.Point(586, 104);
            this.datePickerExpiry.Name = "datePickerExpiry";
            this.datePickerExpiry.Size = new System.Drawing.Size(200, 20);
            this.datePickerExpiry.TabIndex = 11;
            // 
            // btnInsertSuppItem
            // 
            this.btnInsertSuppItem.Location = new System.Drawing.Point(312, 163);
            this.btnInsertSuppItem.Name = "btnInsertSuppItem";
            this.btnInsertSuppItem.Size = new System.Drawing.Size(129, 32);
            this.btnInsertSuppItem.TabIndex = 12;
            this.btnInsertSuppItem.Text = "Insert";
            this.btnInsertSuppItem.UseVisualStyleBackColor = true;
            this.btnInsertSuppItem.Click += new System.EventHandler(this.btnInsertSuppItem_Click);
            // 
            // cboxItems
            // 
            this.cboxItems.FormattingEnabled = true;
            this.cboxItems.Location = new System.Drawing.Point(12, 104);
            this.cboxItems.Name = "cboxItems";
            this.cboxItems.Size = new System.Drawing.Size(189, 21);
            this.cboxItems.TabIndex = 27;
            // 
            // SupplyItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 220);
            this.Controls.Add(this.cboxItems);
            this.Controls.Add(this.btnInsertSuppItem);
            this.Controls.Add(this.datePickerExpiry);
            this.Controls.Add(this.datePickerProduction);
            this.Controls.Add(this.txtSuppItemCount);
            this.Controls.Add(this.labelSupplierName);
            this.Controls.Add(this.LabelWarhouseName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupplyItemForm";
            this.Text = "SupplyItemForm";
            this.Load += new System.EventHandler(this.SupplyItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelWarhouseName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.TextBox txtSuppItemCount;
        private System.Windows.Forms.DateTimePicker datePickerProduction;
        private System.Windows.Forms.DateTimePicker datePickerExpiry;
        private System.Windows.Forms.Button btnInsertSuppItem;
        private System.Windows.Forms.ComboBox cboxItems;
    }
}