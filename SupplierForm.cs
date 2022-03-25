using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corp
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        Commercial_CorpEntities1 ent = new Commercial_CorpEntities1();
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            var suppliers = ent.Suppliers.Select(sup => sup);
            foreach (var sup in suppliers)
            {
                cboxSuppliers.Items.Add(sup.ID);
                ListBoxSuppliers.Items.Add($"{sup.ID}  " +
                    $"{sup.Name}  {sup.Email}  " +
                    $"{sup.Phone}  {sup.Telephone}  " +
                    $"{sup.Fax}  {sup.Website}");
            }
        }

        private void cboxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset
            txtSupplierID.Text = txtSupplierName.Text =
                            txtSupplierEmail.Text = txtSupplierPhone.Text =
                            txtSupplierTele.Text = txtSupplierFax.Text =
                            txtSupplierSite.Text = String.Empty;
            //get data
            int Id = Int32.Parse(cboxSuppliers.Text);
            var suplier = ent.Suppliers.Single(s => s.ID == Id);

            txtSupplierID.Text = suplier.ID.ToString();
            txtSupplierName.Text = suplier.Name;
            txtSupplierEmail.Text = suplier.Email;
            txtSupplierPhone.Text = suplier.Phone;
            txtSupplierTele.Text = suplier.Telephone;
            txtSupplierFax.Text = suplier.Fax;
            txtSupplierSite.Text = suplier.Website;
        }

        private void btnInsertSupplier_Click(object sender, EventArgs e)
        {
            Supplier suplier = new Supplier();

            suplier.ID = Int32.Parse(txtSupplierID.Text);
            suplier.Name = txtSupplierName.Text;
            suplier.Email = txtSupplierEmail.Text;
            suplier.Phone = txtSupplierPhone.Text;
            suplier.Telephone = txtSupplierTele.Text;
            suplier.Fax = txtSupplierFax.Text;
            suplier.Website = txtSupplierSite.Text;

            ent.Suppliers.Add(suplier);
            ent.SaveChanges();

            //add data to the lists
            cboxSuppliers.Items.Add(suplier.ID);
            ListBoxSuppliers.Items.Add($"{suplier.ID}  " +
                    $"{suplier.Name}  {suplier.Email}  " +
                    $"{suplier.Phone}  {suplier.Telephone}  " +
                    $"{suplier.Fax}  {suplier.Website}");
            txtSupplierID.Text = txtSupplierName.Text =
                txtSupplierEmail.Text = txtSupplierPhone.Text =
                txtSupplierTele.Text = txtSupplierFax.Text =
                txtSupplierSite.Text = String.Empty;

            MessageBox.Show("Suplier " + suplier.Name + " Inserted Succesfully");
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            int Id = Int32.Parse(txtSupplierID.Text);
            var suplier = ent.Suppliers.Single(a => a.ID == Id);
            suplier.Name = txtSupplierName.Text;
            suplier.Email = txtSupplierEmail.Text;
            suplier.Phone = txtSupplierPhone.Text;
            suplier.Telephone = txtSupplierTele.Text;
            suplier.Fax = txtSupplierFax.Text;
            suplier.Website = txtSupplierSite.Text;
            ent.SaveChanges();
            txtSupplierID.Text = txtSupplierName.Text =
                txtSupplierEmail.Text = txtSupplierPhone.Text =
                txtSupplierTele.Text = txtSupplierFax.Text =
                txtSupplierSite.Text = String.Empty;
            ListBoxSuppliers.Items.Clear();
            var supliers = ent.Suppliers.Select(c => c);
            foreach (var su in supliers)
            {
                ListBoxSuppliers.Items.Add($"{su.ID}  " +
                    $"{su.Name}  {su.Email}  " +
                    $"{su.Phone}  {su.Telephone}  " +
                    $"{su.Fax}  {su.Website}");
            }

            MessageBox.Show("suplier " + suplier.Name + " Updated Succesfully");
        }
    }
}
