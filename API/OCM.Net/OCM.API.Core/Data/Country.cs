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
    
    public partial class Country
    {
        public Country()
        {
            this.AddressInfoes = new HashSet<AddressInfo>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string ISOCode { get; set; }
    
        public virtual ICollection<AddressInfo> AddressInfoes { get; set; }
    }
}
