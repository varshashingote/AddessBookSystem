using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("!!!Welcome To AddressBook Program!!!!");
            List<CreateContacts> addressBookSysytem = new List<CreateContacts>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please Enter Your choice :\n" +
                                "1.add Contact in List\n" +
                                "2.add new Contact  Contact\n" +
                                "3.Edit Contact\n" +
                                "4.Delete Contact\n" +
                                "5. Add Multiple contact\n" +
                                "6.Add Unique multile Contacts\n" +
                                "7.No Duplicate Entry\n" +
                                "8. SearchPersonUsingStateorCity\n" +
                                "9 .ViewPersonByCityOrState\n" +
                                "10.CountCityOrState \n"

   
                              );

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddressBook address = new AddressBook();
                        Console.WriteLine(" ");
                        address.createContact();
                        break;

                    case 2:
                        AddressBook address1 = new AddressBook();
                        address1.createContact();
                        Console.WriteLine("Information Of Contacts :");
                        address1.Display();
                        address1.addPerson();
                        break;
                    case 3:
                        AddressBook address2 = new AddressBook();
                        address2.EditContact();
                        break;
                    case 4:
                        AddressBook address3 = new AddressBook();
                        address3.DeleteContact();
                        break;
                    case 5:
                        AddressBook address4 = new AddressBook();
                        address4.AddMultipleContact();
                        break;

                    case 6:
                        AddressBook address5 = new AddressBook();
                        address5.NewUser();

                        break;
                    case 7:
                        AddressBook address6 = new AddressBook();
                        address6.CheckDuplicate();
                        break;
                    case 8:
                        AddressBook address7 = new AddressBook();
                        address7.SearchPersonByCityOrState();
                        break;
                    case 9:
                        AddressBook address8 = new AddressBook();
                        address8.ViewPersonByCityOrState();
                        break;
                    case 10:
                        AddressBook address9 = new AddressBook();
                        address9.CountCityOrState();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only give options");
                        break;
                }
                Console.WriteLine("Try Again ");

            }
        }
    }
}




               



















                            