//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace a3.modelold
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int a_id { get; set; }
        public string a_name { get; set; }
        public int c_id { get; set; }
        public Nullable<int> a_fee { get; set; }
        public Nullable<int> a_interest { get; set; }
        public string at_type { get; set; }
        public Nullable<int> a_balance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual Accounttype Accounttype { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
