//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVGSystemCSharp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale_Item
    {
        public string SI_Line_No { get; set; }
        public string SO_ID { get; set; }
        public short SI_Qty { get; set; }
        public double SI_Price { get; set; }
        public Nullable<bool> Prod_VAT { get; set; }
        public string Prod_Code { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Sales_Order Sales_Order { get; set; }
    }
}
