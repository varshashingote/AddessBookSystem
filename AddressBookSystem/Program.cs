using System;
using System.Collections.Generic;
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
            bool value = true;

            while (value)
            {
                Console.WriteLine("Please Enter Your choice :\n" +
                    "1.add Contact in List\n" +
                    "2.add new Contact  Contact\n" +
                    "3.Edit Contact\n"+
                    "4.Delete Contact");

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
                        bool value1 = true;

                        while (value1)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1.addContact\n" + " 2.Edit Contact\n" +
                               "3.Display Contact\n");

                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    address2.addPerson();
                                    break;
                                case 2:
                                    address2.EditContact();
                                    break;

                                case 3:
                                    address2.Display();
                                    break;

                                default:

                                    value = !value;
                                    break;
                            }

                        }
                        break;

                    case 4:

                        AddressBook address3 = new AddressBook();
                        bool value2 = true;

                        while (value2)
                        {
                            Console.WriteLine("Steps to add details:\n" +
                               "1. addContact\n" + "2. Edit Contact\n" +
                               "3.  Delete Contact\n" + "4. Display Contact\n");

                            int choice2 = Convert.ToInt32(Console.ReadLine());
                            switch (choice2)
                            {
                                case 1:
                                    address3.addPerson();
                                    break;

                                case 2:
                                    address3.EditContact();
                                    break;

                                case 3:
                                    address3.DeleteContact();
                                    break;

                                case 4:
                                    address3.Display();
                                    break;
                                default:

                                    value = !value;
                                    break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("wrong input given...please enter correct one");
                        break;
                }
                value = false;
                Console.WriteLine("Try Again ");
                break;
            }
        }
    }
}


                       

                            