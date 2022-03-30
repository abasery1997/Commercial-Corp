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
    public partial class Form1 : Form
    {
       public Commercial_CorpEntities1 ent = new Commercial_CorpEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var warhouses = ent.Warhouses.Select(warhouse => warhouse);
            var Unites = ent.MeasureUnites.Select(unite => unite);
            foreach (var warhouse in warhouses)
            {
                cboxWars.Items.Add(warhouse.ID);
            }
            foreach (var unite in Unites)
            {
                cboxUnites.Items.Add(unite.Unite);
            }
        }

        private void btnInsertWar_Click(object sender, EventArgs e)
        {
            Warhouse warhouse = new Warhouse();
            warhouse.ID = Int32.Parse(txtWarID.Text);
            warhouse.Name = txtWarName.Text;
            warhouse.Manager = txtWarManager.Text;
            ent.Warhouses.Add(warhouse);
            ent.SaveChanges();
            cboxWars.Items.Add(warhouse.ID);
            txtWarID.Text = txtWarManager.Text = txtWarName.Text = String.Empty;
            MessageBox.Show("warhouse " + warhouse.Name + " Inserted Succesfully");
        }

        private void cboxWars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset
            txtWarID.Text = txtWarManager.Text = txtWarName.Text = String.Empty;
            lboxItems.Items.Clear();

            //get data
            int Id = Int32.Parse(cboxWars.Text);
            var warhouse = ent.Warhouses.Single(a => a.ID == Id);

            txtWarID.Text = warhouse.ID.ToString();
            txtWarName.Text = warhouse.Name;
            txtWarManager.Text = warhouse.Manager;


            //fill items
            var items = from Item in ent.Items where Item.WarhouseID == warhouse.ID select Item ;

            foreach (var item in items)
            {
                var unite = ent.MeasureUnites.Single(a => a.ID == item.MeasureID);
                lboxItems.Items.Add($"{item.Code}  {item.Name}  {unite.Unite}  {item.Amount}   {warhouse.Name}");
            }
        }

        private void btnUpdateWar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtWarID.Text);
            var warhouse = ent.Warhouses.Single(a => a.ID == id);
            warhouse.Name = txtWarName.Text;
            warhouse.Manager = txtWarManager.Text;
            ent.SaveChanges();
            txtWarID.Text = txtWarManager.Text = txtWarName.Text = String.Empty;
            MessageBox.Show("warhouse number " + id + " updated Succesfully");

        }

        private void btnInsertUnite_Click(object sender, EventArgs e)
        {
            MeasureUnite unite = new MeasureUnite();

            unite.ID = Int32.Parse(txtUniteID.Text);
            unite.Unite = txtUniteName.Text;
            ent.MeasureUnites.Add(unite);
            ent.SaveChanges();
            cboxUnites.Items.Add(unite.Unite);
            txtUniteID.Text = txtUniteName.Text = String.Empty;
            MessageBox.Show("Mesure Unite " + unite.Unite + " added Succesfully");

        }

        private void btnItemInsert_Click(object sender, EventArgs e)
        {
            if (cboxWars.Text != String.Empty)
            {

                Item item = new Item();
                item.Code = Int32.Parse(txtItemCode.Text);
                item.Name = txtItemName.Text;
                var unite = ent.MeasureUnites.Single(a => a.Unite == cboxUnites.Text);
                int warhouseID = Int32.Parse(cboxWars.Text);
                var warhouse = ent.Warhouses.Single(a => a.ID == warhouseID);
                item.MeasureID = unite.ID;
                item.WarhouseID = warhouse.ID;
                item.Amount = 0;
                ent.Items.Add(item);
                ent.SaveChanges();
                lboxItems.Items.Add($"{item.Code}  {item.Name}  {unite.Unite} {item.Amount}  {warhouse.Name}");
                txtItemCode.Text = txtItemName.Text = cboxUnites.Text = String.Empty;
                MessageBox.Show("Item " + item.Name + " added Succesfully");

            }
            else
            {
                MessageBox.Show("please select warhouse first to insert item in ");
            }

        }

        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            int code = Int32.Parse(txtItemCode.Text);

            var oldItem = ent.Items.Single(a => a.Code == code);
            oldItem.Name = txtItemName.Text;
            ent.SaveChanges();
            txtItemCode.Text = txtItemName.Text = cboxUnites.Text = String.Empty;
            MessageBox.Show("Item " + oldItem.Name + " Updated Succesfully");
            
            lboxItems.Items.Clear();
            // fill items
            int warhouseID = Int32.Parse(cboxWars.Text);
            var warhouse = ent.Warhouses.Single(a => a.ID == warhouseID);
            var items = from Item in ent.Items where Item.WarhouseID == warhouse.ID select Item;

            foreach (var item in items)
            {
                var unite = ent.MeasureUnites.Single(a => a.ID == item.MeasureID);
                lboxItems.Items.Add($"{item.Code}  {item.Name}  {unite.Unite} {item.Amount}  {warhouse.Name}");
                Console.WriteLine(item.Amount);
            }


        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm CForm = new CustomerForm();
            CForm.ShowDialog();

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm SForm = new SupplierForm();
            SForm.ShowDialog();
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            SupplyForm supplyForm = new SupplyForm(ent);
            supplyForm.ShowDialog();
        }

        
    }
}
