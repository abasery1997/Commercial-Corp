//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corp
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplyItem
    {
        public int SupplyID { get; set; }
        public int itemCode { get; set; }
        public int Quantity { get; set; }
        public System.DateTime productionDate { get; set; }
        public System.DateTime Expiry { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Supply Supply { get; set; }
    }
}