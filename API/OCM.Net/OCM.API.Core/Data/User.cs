//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OCM.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.AuditLogs = new HashSet<AuditLog>();
            this.ChargePoints = new HashSet<ChargePoint>();
            this.EditQueueItems = new HashSet<EditQueueItem>();
            this.EditQueueItems1 = new HashSet<EditQueueItem>();
            this.UserComments = new HashSet<UserComment>();
            this.MediaItems = new HashSet<MediaItem>();
            this.DataProviderUsers = new HashSet<DataProviderUser>();
        }
    
        public int ID { get; set; }
        public string IdentityProvider { get; set; }
        public string Identifier { get; set; }
        public string Username { get; set; }
        public string CurrentSessionToken { get; set; }
        public string Profile { get; set; }
        public string Location { get; set; }
        public string WebsiteURL { get; set; }
        public Nullable<int> ReputationPoints { get; set; }
        public string Permissions { get; set; }
        public string PermissionsRequested { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateLastLogin { get; set; }
        public bool IsProfilePublic { get; set; }
        public bool IsEmergencyChargingProvider { get; set; }
        public bool IsPublicChargingProvider { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string APIKey { get; set; }
    
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
        public virtual ICollection<ChargePoint> ChargePoints { get; set; }
        public virtual ICollection<EditQueueItem> EditQueueItems { get; set; }
        public virtual ICollection<EditQueueItem> EditQueueItems1 { get; set; }
        public virtual ICollection<UserComment> UserComments { get; set; }
        public virtual ICollection<MediaItem> MediaItems { get; set; }
        public virtual ICollection<DataProviderUser> DataProviderUsers { get; set; }
    }
}
