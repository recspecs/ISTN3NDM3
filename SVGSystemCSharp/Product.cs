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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Purchase_Item = new HashSet<Purchase_Item>();
            this.Sale_Item = new HashSet<Sale_Item>();
        }
    
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public double Prod_Cost_Price { get; set; }
        public string Prod_Stock_Level { get; set; }
        public Nullable<bool> Prod_VAT { get; set; }
        public string Prod_Categories { get; set; }
        public Nullable<int> Prod_Reorder_Threshold { get; set; }
        public Nullable<bool> IsArchived { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Item> Purchase_Item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale_Item> Sale_Item { get; set; }
    }
}
