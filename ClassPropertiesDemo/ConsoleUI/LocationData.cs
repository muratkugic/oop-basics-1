﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class LocationData
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string FullAddress
        {
            get
            {
                return $"Street: { StreetAddress }\nCity: { City }\nState: { State }\nZipCode: { ZipCode }";
            }
        }

        public LocationData()
        {

        }

        public LocationData(string streedAddress, string city, string state, string zipCode)
        {
            StreetAddress = streedAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
