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
    
    public partial class DemandItem
    {
        public int DemandID { get; set; }
        public int ItemCode { get; set; }
        public int Quantity { get; set; }
    
        public virtual Demand Demand { get; set; }
        public virtual Item Item { get; set; }
    }
}
