namespace Corp
{
    partial class CustomerForm
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
            this.ListBoxCustomers = new System.Windows.Forms.ListBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerFax = new System.Windows.Forms.TextBox();
            this.txtCustomerTele = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.cboxCustomers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxCustomers
            // 
            this.ListBoxCustomers.FormattingEnabled = true;
            this.ListBoxCustomers.Location = new System.Drawing.Point(397, 34);
            this.ListBoxCustomers.Name = "ListBoxCustomers";
            this.ListBoxCustomers.Size = new System.Drawing.Size(366, 368);
            this.ListBoxCustomers.TabIndex = 22;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(153, 368);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(98, 43);
            this.btnUpdateCustomer.TabIndex = 30;
            this.btnUpdateCustomer.Text = "Update By ID";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.Location = new System.Drawing.Point(27, 368);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(98, 43);
            this.btnInsertCustomer.TabIndex = 29;
            this.btnInsertCustomer.Text = "Insert";
            this.btnInsertCustomer.UseVisualStyleBackColor = true;
            this.btnInsertCustomer.Click += new System.EventHandler(this.btnInsertCustomer_Click);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(227, 118);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(147, 20);
            this.txtCustomerEmail.TabIndex = 28;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(94, 118);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 27;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(25, 118);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(42, 20);
            this.txtCustomerID.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID";
            // 
            // txtCustomerFax
            // 
            this.txtCustomerFax.Location = new System.Drawing.Point(274, 226);
            this.txtCustomerFax.Name = "txtCustomerFax";
            this.txtCustomerFax.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerFax.TabIndex = 36;
            // 
            // txtCustomerTele
            // 
            this.txtCustomerTele.Location = new System.Drawing.Point(153, 226);
            this.txtCustomerTele.Name = "txtCustomerTele";
            this.txtCustomerTele.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerTele.TabIndex = 35;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(25, 226);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPhone.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "TelePhone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Phone";
            // 
            // txtCustomerSite
            // 
            this.txtCustomerSite.Location = new System.Drawing.Point(59, 305);
            this.txtCustomerSite.Name = "txtCustomerSite";
            this.txtCustomerSite.Size = new System.Drawing.Size(271, 20);
            this.txtCustomerSite.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "WebSite";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(276, 368);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(98, 43);
            this.btnDeleteCustomer.TabIndex = 39;
            this.btnDeleteCustomer.Text = "Delete By ID";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // cboxCustomers
            // 
            this.cboxCustomers.FormattingEnabled = true;
            this.cboxCustomers.Location = new System.Drawing.Point(182, 34);
            this.cboxCustomers.Name = "cboxCustomers";
            this.cboxCustomers.Size = new System.Drawing.Size(173, 21);
            this.cboxCustomers.TabIndex = 41;
            this.cboxCustomers.SelectedIndexChanged += new System.EventHandler(this.cboxCustomers_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Customers :";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxCustomers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.txtCustomerSite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerFax);
            this.Controls.Add(this.txtCustomerTele);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnInsertCustomer);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ListBoxCustomers);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxCustomers;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnInsertCustomer;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerFax;
        private System.Windows.Forms.TextBox txtCustomerTele;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.ComboBox cboxCustomers;
        private System.Windows.Forms.Label label8;
    }
}