using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class Name
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Name(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}
