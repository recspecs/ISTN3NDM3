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
    
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.Purchase_Order = new HashSet<Purchase_Order>();
        }
    
        public int Supp_ID { get; set; }
        public string Supp_Name { get; set; }
        public string Supp_Contact_No { get; set; }
        public string Supp_Email { get; set; }
        public string Supp_Contact_Person { get; set; }
        public string Supp_Address1 { get; set; }
        public string Supp_Address2 { get; set; }
        public string Supp_Surburb { get; set; }
        public string Supp_City { get; set; }
        public string Supp_Postal_Code { get; set; }
        public Nullable<bool> IsArchived { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Order> Purchase_Order { get; set; }
    }
}
