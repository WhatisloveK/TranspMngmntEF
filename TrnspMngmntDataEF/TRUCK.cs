//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrnspMngmntDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRUCK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRUCK()
        {
            this.TRUCKERS = new HashSet<TRUCKER>();
        }
    
        public int TRUCK_ID { get; set; }
        public Nullable<int> TRUCK_NUMBER { get; set; }
        public Nullable<int> TRUCK_TYPE { get; set; }
        public Nullable<System.DateTime> TRUCK_INSURANCE_EXPIRATION { get; set; }
        public Nullable<int> TRUCK_TRAILER { get; set; }
    
        public virtual TRAILER TRAILER { get; set; }
        public virtual TRUCK_TYPES TRUCK_TYPES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRUCKER> TRUCKERS { get; set; }
    }
}