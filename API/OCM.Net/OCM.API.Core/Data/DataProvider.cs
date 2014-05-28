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
    
    public partial class DataProvider
    {
        public DataProvider()
        {
            this.ChargePoints = new HashSet<ChargePoint>();
            this.MetadataGroups = new HashSet<MetadataGroup>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string WebsiteURL { get; set; }
        public string Comments { get; set; }
        public Nullable<int> DataProviderStatusTypeID { get; set; }
        public bool IsRestrictedEdit { get; set; }
        public Nullable<bool> IsOpenDataLicensed { get; set; }
        public Nullable<bool> IsApprovedImport { get; set; }
        public string License { get; set; }
    
        public virtual ICollection<ChargePoint> ChargePoints { get; set; }
        public virtual DataProviderStatusType DataProviderStatusType { get; set; }
        public virtual ICollection<MetadataGroup> MetadataGroups { get; set; }
    }
}
