using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBook
{
    class AddressBook
    {
        public List<Entry> _addressBookList;
       

        public AddressBook()
        {
            _addressBookList = new List<Entry>();
        }

       
        public Entry GatherInfoForAddressBook(Name name,Address address,string phoneNumber, string email)
        {
          Entry entry = new Entry(name, address, phoneNumber, email);
         _addressBookList.Add(entry);

           

            return entry;

        }
            
       

       

        public bool IsQuit(string value)
        {
            if(value.ToLower() == "quit")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string GetPhoneNumber()
        {
            Console.WriteLine("Please enter phone number: ");
            string phone = ReplaceEmpty(Console.ReadLine());

            return (IsPhoneNumber(phone)) ? phone : "";
        }

       public string ReplaceEmpty(string value)
        {
            return (value != null) ? value : "";
        }

    

        public bool IsPhoneNumber(string phoneNumber)
        {
            return Regex.Match(phoneNumber, @"^(\+[0-9]{9})$").Success;
        }



        public void SearchContact(string name, List<Entry> list)

            {
         
          int count =_addressBookList.Count;
            Entry foundContact = null;
            if(list.Count > 0)
            {
            foreach (Entry entry in _addressBookList)
            {
                Console.WriteLine(entry);
                if (entry.name.firstName == name)
                {
                    Name searchedName = new Name(entry.name.firstName, entry.name.lastName);
                    Address searchedAddress = new Address(entry.address.streetNumber, entry.address.streetName, entry.address.city, entry.address.country);
                    foundContact = new Entry(searchedName, searchedAddress, entry.phoneNumber, entry.email);
                }
            }

            Console.WriteLine(foundContact.name.firstName + " " + foundContact.name.lastName + " " + foundContact.email + " " + foundContact.phoneNumber);
            }
            //return foundContact;
        }
    }
}
