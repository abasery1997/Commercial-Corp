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
    public partial class SupplyForm : Form
    {
        public static int WarhouseID;
        public static int SupplierID;
        public static int ItemCOunt;
        public static int Iteration;
        public static int SupplyID;
        Commercial_CorpEntities1 ent;
        public SupplyForm(Commercial_CorpEntities1 _ent)
        {
            InitializeComponent();
            ent = _ent;
        }
        private void SupplyForm_Load(object sender, EventArgs e)
        {
            var warhouses = ent.Warhouses.Select(warhouse => warhouse);
            foreach (var warhouse in warhouses)
            {
                cboxWars.Items.Add(warhouse.ID);
            }
            var supplies = ent.Supplies.Select(supp => supp.ID);
            foreach (var supply in supplies)
            {
                cboxSupplyID.Items.Add(supply);
            }
            var suppliers = ent.Suppliers.Select(supp => supp.ID);
            foreach (var supp in suppliers)
            {
                cboxSuppliers.Items.Add(supp);
            }

        }
        private void btnInsertSupply_Click(object sender, EventArgs e)
        {
            Supply supply = new Supply();
            SupplyID = supply.ID = Int32.Parse(txtSupplyID.Text);
            WarhouseID = supply.WarhouseID = Int32.Parse(cboxWars.Text);
            SupplierID = supply.SupplierID = Int32.Parse(cboxSuppliers.Text);
            supply.SupplyDate = DateTime.Parse(DatePickerSupplayDate.Text);

            ent.Supplies.Add(supply);
            ent.SaveChanges();
            cboxSupplyID.Items.Add(supply.ID);
            int count = ItemCOunt = (Int32)txtItemNumber.Value;
            for (int i = 1; i <= count; i++)
            {
                Iteration = i;
                SupplyItemForm supplyItemForm = new SupplyItemForm(ent);
                supplyItemForm.ShowDialog();
            }
            txtSupplyID.Text = cboxSuppliers.Text = DatePickerSupplayDate.Text = String.Empty;
            MessageBox.Show($"Supply {supply.ID} added Successfully ");
        }




    }
}
