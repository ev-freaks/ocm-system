﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OCM.API.Common.Model.Extensions
{
    public class AddressInfo
    {
        public static Model.AddressInfo FromDataModel(Core.Data.AddressInfo source, bool isVerboseMode)
        {
            if (source == null) return null;

            Model.AddressInfo a = new Model.AddressInfo();
            a.ID = source.ID;
            a.Title = source.Title;
            a.AddressLine1 = source.AddressLine1;
            a.AddressLine2 = source.AddressLine2;
            a.Town = source.Town;
            a.StateOrProvince = source.StateOrProvince;
            a.Postcode = source.Postcode;

            if (source.Country != null)
            {
                a.CountryID = source.CountryID;
                if (isVerboseMode)
                {
                    a.Country = Model.Extensions.Country.FromDataModel(source.Country);
                }
            }

            a.Latitude = source.Latitude;
            a.Longitude = source.Longitude;
            a.ContactTelephone1 = source.ContactTelephone1;
            a.ContactTelephone2 = source.ContactTelephone2;
            a.ContactEmail = source.ContactEmail;
            a.AccessComments = source.AccessComments;
            a.GeneralComments = source.GeneralComments;
            a.RelatedURL = source.RelatedURL;
            return a;
        }
    }
}