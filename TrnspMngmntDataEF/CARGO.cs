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
    
    public partial class CARGO
    {
        public int CG_ID { get; set; }
        public Nullable<int> CG_NUMBER { get; set; }
        public Nullable<int> CG_WEIGHT { get; set; }
        public Nullable<System.DateTime> CG_DEPARTURE_DATE { get; set; }
        public Nullable<System.DateTime> CG_ARRIVAL_DATE { get; set; }
        public Nullable<int> CG_DESTINATION { get; set; }
        public Nullable<int> CG_DEPARTURE_PLACE { get; set; }
        public Nullable<int> CG_TRUCKER { get; set; }
        public Nullable<System.TimeSpan> CG_DEPARTURE_TIME { get; set; }
        public Nullable<System.TimeSpan> CG_ARRIVAL_TIME { get; set; }
    
        public virtual DEPARTURE DEPARTURE { get; set; }
        public virtual DEPARTURE DEPARTURE1 { get; set; }
        public virtual TRUCKER TRUCKER { get; set; }
    }
}