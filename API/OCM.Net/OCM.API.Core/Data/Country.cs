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
    
    public partial class Country
    {
        public Country()
        {
            this.AddressInfoes = new HashSet<AddressInfo>();
            this.OperatorCountries = new HashSet<OperatorCountry>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string ISOCode { get; set; }
    
        public virtual ICollection<AddressInfo> AddressInfoes { get; set; }
        public virtual ICollection<OperatorCountry> OperatorCountries { get; set; }
    }
}
