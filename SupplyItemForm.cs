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
    public partial class SupplyItemForm : Form
    {
    Commercial_CorpEntities1 ent;

        public SupplyItemForm(Commercial_CorpEntities1 _ent)
        {
            InitializeComponent();
            ent = _ent;
        }

        private void SupplyItemForm_Load(object sender, EventArgs e)
        {
            int WarhouseID = SupplyForm.WarhouseID;
            int SupplierID = SupplyForm.SupplierID;
            int ItemCOunt = SupplyForm.ItemCOunt;
            int Iteration = SupplyForm.Iteration;

            labelItemCounter.Text = $"Item {Iteration} of {ItemCOunt}";

            var warhouse =  ent.Warhouses.Single(a => a.ID == WarhouseID);
            var supplier = ent.Suppliers.Single(a => a.ID == SupplierID);
            LabelWarhouseName.Text = warhouse.Name;
            labelSupplierName.Text = supplier.Name;
            if(Iteration == ItemCOunt )
            {
                btnInsertSuppItem.Text = "Finish";
            }
            else
            {
                btnInsertSuppItem.Text = "Next";
            }

            var items = from Item in ent.Items where Item.WarhouseID == warhouse.ID select Item;

            foreach (var item in items)
            {
                var unite = ent.MeasureUnites.Single(a => a.ID == item.MeasureID);
                cboxItems.Items.Add($"{item.Code} {item.Name} {unite.Unite}");
            }


           
        }

        private void btnInsertSuppItem_Click(object sender, EventArgs e)
        {
            int SupplyID = SupplyForm.SupplyID;
            int  itemCode =Int32.Parse( cboxItems.Text.Split(' ')[0]);
            var item = ent.Items.Single(a => a.Code == itemCode);

            
            SupplyItem supplyItem = new SupplyItem();
            supplyItem.SupplyID = SupplyID;
             supplyItem.Quantity = Int32.Parse(txtSuppItemCount.Text);
            supplyItem.itemCode = itemCode;
            supplyItem.productionDate = DateTime.Parse(datePickerProduction.Text);
            supplyItem.Expiry = DateTime.Parse(datePickerExpiry.Text);

            ent.SupplyItems.Add(supplyItem);
            ent.SaveChanges();
            item.Amount += Int32.Parse(txtSuppItemCount.Text);
            ent.SaveChanges();
            this.Close();
        }
    }
}
