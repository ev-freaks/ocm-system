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
    
    public partial class UserComment
    {
        public int ID { get; set; }
        public int ChargePointID { get; set; }
        public int UserCommentTypeID { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
        public Nullable<byte> Rating { get; set; }
        public string RelatedURL { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<byte> CheckinStatusTypeID { get; set; }
        public Nullable<bool> IsActionedByEditor { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
    
        public virtual ChargePoint ChargePoint { get; set; }
        public virtual CheckinStatusType CheckinStatusType { get; set; }
        public virtual User User { get; set; }
        public virtual UserCommentType UserCommentType { get; set; }
    }
}
