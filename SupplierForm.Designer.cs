namespace Corp
{
    partial class SupplierForm
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
            this.cboxSuppliers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.txtSupplierSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupplierFax = new System.Windows.Forms.TextBox();
            this.txtSupplierTele = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnInsertSupplier = new System.Windows.Forms.Button();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListBoxSuppliers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboxSuppliers
            // 
            this.cboxSuppliers.FormattingEnabled = true;
            this.cboxSuppliers.Location = new System.Drawing.Point(188, 37);
            this.cboxSuppliers.Name = "cboxSuppliers";
            this.cboxSuppliers.Size = new System.Drawing.Size(173, 21);
            this.cboxSuppliers.TabIndex = 61;
            this.cboxSuppliers.SelectedIndexChanged += new System.EventHandler(this.cboxSuppliers_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Suppliers :";
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(282, 371);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(98, 43);
            this.btnDeleteSupplier.TabIndex = 59;
            this.btnDeleteSupplier.Text = "Delete By ID";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // txtSupplierSite
            // 
            this.txtSupplierSite.Location = new System.Drawing.Point(65, 308);
            this.txtSupplierSite.Name = "txtSupplierSite";
            this.txtSupplierSite.Size = new System.Drawing.Size(271, 20);
            this.txtSupplierSite.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "WebSite";
            // 
            // txtSupplierFax
            // 
            this.txtSupplierFax.Location = new System.Drawing.Point(280, 229);
            this.txtSupplierFax.Name = "txtSupplierFax";
            this.txtSupplierFax.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierFax.TabIndex = 56;
            // 
            // txtSupplierTele
            // 
            this.txtSupplierTele.Location = new System.Drawing.Point(159, 229);
            this.txtSupplierTele.Name = "txtSupplierTele";
            this.txtSupplierTele.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierTele.TabIndex = 55;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(31, 229);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierPhone.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Fax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "TelePhone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Phone";
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(159, 371);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(98, 43);
            this.btnUpdateSupplier.TabIndex = 50;
            this.btnUpdateSupplier.Text = "Update By ID";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnInsertSupplier
            // 
            this.btnInsertSupplier.Location = new System.Drawing.Point(33, 371);
            this.btnInsertSupplier.Name = "btnInsertSupplier";
            this.btnInsertSupplier.Size = new System.Drawing.Size(98, 43);
            this.btnInsertSupplier.TabIndex = 49;
            this.btnInsertSupplier.Text = "Insert";
            this.btnInsertSupplier.UseVisualStyleBackColor = true;
            this.btnInsertSupplier.Click += new System.EventHandler(this.btnInsertSupplier_Click);
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Location = new System.Drawing.Point(233, 121);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(147, 20);
            this.txtSupplierEmail.TabIndex = 48;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(100, 121);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierName.TabIndex = 47;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(31, 121);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(42, 20);
            this.txtSupplierID.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "ID";
            // 
            // ListBoxSuppliers
            // 
            this.ListBoxSuppliers.FormattingEnabled = true;
            this.ListBoxSuppliers.Location = new System.Drawing.Point(403, 37);
            this.ListBoxSuppliers.Name = "ListBoxSuppliers";
            this.ListBoxSuppliers.Size = new System.Drawing.Size(366, 368);
            this.ListBoxSuppliers.TabIndex = 42;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxSuppliers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.txtSupplierSite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSupplierFax);
            this.Controls.Add(this.txtSupplierTele);
            this.Controls.Add(this.txtSupplierPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.btnInsertSupplier);
            this.Controls.Add(this.txtSupplierEmail);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListBoxSuppliers);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxSuppliers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.TextBox txtSupplierSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSupplierFax;
        private System.Windows.Forms.TextBox txtSupplierTele;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnInsertSupplier;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListBoxSuppliers;
    }
}