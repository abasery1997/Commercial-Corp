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
        public SupplyItemForm()
        {
            InitializeComponent();
        }
        Commercial_CorpEntities1 ent = new Commercial_CorpEntities1();

        private void SupplyItemForm_Load(object sender, EventArgs e)
        {
            int WarhouseID = SupplyForm.WarhouseID;
            int SupplierID = SupplyForm.SupplierID;
            int ItemCOunt = SupplyForm.ItemCOunt;
            int Iteration = SupplyForm.Iteration;
            var warhouse = ent.Warhouses.Single(a => a.ID == WarhouseID);
            var supplier = ent.Suppliers.Single(a => a.ID == SupplierID);
            LabelWarhouseName.Text = warhouse.Name;
            labelSupplierName.Text = supplier.Name;
        }
    }
}
