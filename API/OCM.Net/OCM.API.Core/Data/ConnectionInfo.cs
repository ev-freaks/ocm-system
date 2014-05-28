//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OCM.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConnectionInfo
    {
        public int ID { get; set; }
        public int ChargePointID { get; set; }
        public int ConnectionTypeID { get; set; }
        public string Reference { get; set; }
        public Nullable<int> StatusTypeID { get; set; }
        public Nullable<int> Amps { get; set; }
        public Nullable<int> Voltage { get; set; }
        public Nullable<double> PowerKW { get; set; }
        public Nullable<short> CurrentTypeID { get; set; }
        public Nullable<int> LevelTypeID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Comments { get; set; }
    
        public virtual ChargePoint ChargePoint { get; set; }
        public virtual ChargerType ChargerType { get; set; }
        public virtual CurrentType CurrentType { get; set; }
        public virtual StatusType StatusType { get; set; }
        public virtual ConnectionType ConnectionType { get; set; }
    }
}
