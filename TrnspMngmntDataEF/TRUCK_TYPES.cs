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
    
    public partial class TRUCK_TYPES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRUCK_TYPES()
        {
            this.TRUCKs = new HashSet<TRUCK>();
        }
    
        public int TYPE_ID { get; set; }
        public string TYPE_MODEL { get; set; }
        public Nullable<int> TYPE_CAPACITY { get; set; }
        public string TYPE_CLASS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRUCK> TRUCKs { get; set; }
    }
}
