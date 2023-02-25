﻿using System;
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
                    "4.Delete Contact\n"+
                    "5. Add Multiple contact " +
                    "6.Add Unique multile Contacts" +
                    "7.No Duplicate Entry"
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
                                case 5:
                                    address3.AddMultipleContact();
                                    break;
                                default:

                                    value = !value;
                                    break;
                            }
                        }
                        break;
                    case 5:
                        AddressBook address4= new AddressBook();
                        address4.AddMultipleContact(); 
                        bool check3 = true;

                        while (check3)
                        {
                            Console.WriteLine("Follow Steps to add details:\n" +
                               "1) To addContact\n" + "2) To Edit Contact\n" +
                               "3) To Remove Contact\n" + "4) Adding Multiple Contacts\n" +
                               "5) To Display Contact\n");

                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    address4.addPerson();
                                    break;

                                case 2:
                                    address4.EditContact();
                                    break;

                                case 3:
                                    address4.DeleteContact();
                                    break;

                                case 4:
                                    address4.AddMultipleContact();
                                    break;

                                case 5:
                                    address4.Display();
                                    break;

                                default:

                                    value = !value;
                                    break;
                            }
                        }
                        break;
                    case 6:
                        AddressBook address5 = new AddressBook();
                        address5.NewUser();

                        break;
                    case 7:
                        AddressBook address6 = new AddressBook();
                        address6.CheckDuplicate();
                        break;
                        
                    default:
                        Console.WriteLine("Please Enter Right option");
                        break;
                }
                value = false;
                Console.WriteLine("Try Again ");
                break;
            }
        }
    }
}


                       

                            