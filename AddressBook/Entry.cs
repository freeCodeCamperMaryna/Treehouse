using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBook
{
    class Entry
    {
       
        public string phoneNumber { get; set; }
        public Address address { get; set; }
        public Name name { get; set; }
        public string email { get; set; }


        public Entry(Name myName, Address myAddress, string myPhoneNumber,string myEmail)
        {
            name = myName;
            address = myAddress;
            phoneNumber =myPhoneNumber;
            email = myEmail;
        }
       
    }
}
