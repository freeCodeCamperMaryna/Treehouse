using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class Address
    {
        public int streetNumber { get; set; }
        public string streetName { get; set; }
        public string city { get; set; }
        public string country { get; set; }


        public Address(int StreeetNumber,string StreetName, string City, string Country)
        {
            streetNumber = StreeetNumber;
            streetName = StreetName;
            city = City;
            country = Country;
        }


     
    }
}
