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
    
    public partial class Purchase_Item
    {
        public int PI_Line_No { get; set; }
        public string PO_No { get; set; }
        public short PI_Qty { get; set; }
        public double PI_Price { get; set; }
        public string Prod_Code { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Purchase_Order Purchase_Order { get; set; }
    }
}
