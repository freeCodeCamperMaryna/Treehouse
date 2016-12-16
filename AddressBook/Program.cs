using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {

            AddressBook ab = new AddressBook();
            List<Entry> _addressBookList = new List<Entry>();
            Entry e = null;
            while (true) { 
            try
            {
                
                Console.WriteLine("Type 1 to add contact to address book");
                Console.WriteLine("Type 2 to search contact in address book");
                int input = int.Parse(Console.ReadLine());
               
                    switch (input)
                {

                    case 1:

                            Console.WriteLine("type \"quit\" to exit");
                            Console.WriteLine("Please enter the first name: ");
                            string fn = Console.ReadLine();



                            Console.WriteLine("Please enter the last name: ");
                            string ln = Console.ReadLine();
                            Name name = new Name(fn, ln);


                            Console.WriteLine("Please enter street number: ");
                            int streetNumber = int.Parse(ab.ReplaceEmpty(Console.ReadLine()));


                            Console.WriteLine("Please enter the street name: ");
                            string streetName = ab.ReplaceEmpty(Console.ReadLine());


                            Console.WriteLine("Please the enter city: ");
                            string city = ab.ReplaceEmpty(Console.ReadLine());

                            Console.WriteLine("Please enter the country: ");
                            string country = ab.ReplaceEmpty(Console.ReadLine());
                            Address address = new Address(streetNumber, streetName, city, country);

                            string phoneNumber = ab.GetPhoneNumber();


                            Console.WriteLine("Please enter email: ");
                            string email = Console.ReadLine() ?? "";
                            e = ab.GatherInfoForAddressBook(name, address, phoneNumber, email);
                          _addressBookList.Add(e);
                            break;




                    case 2:
                           //Console.WriteLine("list count" + _addressBookList.Count);
                           
                        Console.WriteLine("Please enter the first name");

                        string firstName = Console.ReadLine();
                            
                            
                                ab.SearchContact(firstName, _addressBookList);
                        break;
                    default:
                        break;

                }

            }
            
                catch (FormatException ex)
            {
                Console.WriteLine("input is invalid");
            }
            }

            Console.ReadKey();
        }
           
           


        }
    }

