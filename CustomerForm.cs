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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        Commercial_CorpEntities1 ent = new Commercial_CorpEntities1();
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var customers = ent.Customers.Select(customer => customer);
            foreach (var customer in customers)
            {
                cboxCustomers.Items.Add(customer.ID);
                ListBoxCustomers.Items.Add($"{customer.ID}  " +
                    $"{customer.Name}  {customer.Email}  " +
                    $"{customer.Phone}  {customer.Telephone}  " +
                    $"{customer.Fax}  {customer.Website}");
            }

        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.ID = Int32.Parse(txtCustomerID.Text);
            customer.Name = txtCustomerName.Text;
            customer.Email = txtCustomerEmail.Text;
            customer.Phone = txtCustomerPhone.Text;
            customer.Telephone = txtCustomerTele.Text;
            customer.Fax = txtCustomerFax.Text;
            customer.Website = txtCustomerSite.Text;

            ent.Customers.Add(customer);
            ent.SaveChanges();

            //add data to the lists
            cboxCustomers.Items.Add(customer.ID);
            ListBoxCustomers.Items.Add($"{customer.ID}  " +
                    $"{customer.Name}  {customer.Email}  " +
                    $"{customer.Phone}  {customer.Telephone}  " +
                    $"{customer.Fax}  {customer.Website}");
            txtCustomerID.Text = txtCustomerName.Text =
                txtCustomerEmail.Text = txtCustomerPhone.Text =
                txtCustomerTele.Text = txtCustomerFax.Text =
                txtCustomerSite.Text = String.Empty;

            MessageBox.Show("Customer " + customer.Name + " Inserted Succesfully");

        }

        private void cboxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset
            txtCustomerID.Text = txtCustomerName.Text =
                            txtCustomerEmail.Text = txtCustomerPhone.Text =
                            txtCustomerTele.Text = txtCustomerFax.Text =
                            txtCustomerSite.Text = String.Empty;
            //get data
            int Id = Int32.Parse(cboxCustomers.Text);
            var customer = ent.Customers.Single(a => a.ID == Id);

            txtCustomerID.Text = customer.ID.ToString();
            txtCustomerName.Text = customer.Name;
            txtCustomerEmail.Text = customer.Email;
            txtCustomerPhone.Text = customer.Phone;
            txtCustomerTele.Text = customer.Telephone;
            txtCustomerFax.Text = customer.Fax;
            txtCustomerSite.Text = customer.Website;



        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            int Id = Int32.Parse(txtCustomerID.Text);
            var customer = ent.Customers.Single(a => a.ID == Id);
            customer.Name = txtCustomerName.Text;
            customer.Email = txtCustomerEmail.Text;
            customer.Phone = txtCustomerPhone.Text;
            customer.Telephone = txtCustomerTele.Text;
            customer.Fax = txtCustomerFax.Text;
            customer.Website = txtCustomerSite.Text;
            ent.SaveChanges();
            txtCustomerID.Text = txtCustomerName.Text =
                txtCustomerEmail.Text = txtCustomerPhone.Text =
                txtCustomerTele.Text = txtCustomerFax.Text =
                txtCustomerSite.Text = String.Empty;
            ListBoxCustomers.Items.Clear();
            var customers = ent.Customers.Select(c => c);
            foreach (var cu in customers)
            {
                ListBoxCustomers.Items.Add($"{cu.ID}  " +
                    $"{cu.Name}  {cu.Email}  " +
                    $"{cu.Phone}  {cu.Telephone}  " +
                    $"{cu.Fax}  {cu.Website}");
            }
            
            MessageBox.Show("Customer " + customer.Name + " Updated Succesfully");


        }
    }
}
