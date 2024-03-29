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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Customer_Payment = new HashSet<Customer_Payment>();
            this.Purchase_Order = new HashSet<Purchase_Order>();
            this.Sales_Order = new HashSet<Sales_Order>();
        }
    
        public int Emp_ID { get; set; }
        public string Emp_FName { get; set; }
        public string Emp_SName { get; set; }
        public string Emp_Email { get; set; }
        public string Emp_Password { get; set; }
        public string Emp_Contact_No { get; set; }
        public string Emp_Type { get; set; }
        public Nullable<bool> IsArchived { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Payment> Customer_Payment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Order> Purchase_Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Order> Sales_Order { get; set; }
    }
}
