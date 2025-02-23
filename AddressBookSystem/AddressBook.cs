﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public List<CreateContacts> addressBookSysytem = new List<CreateContacts>();
        public void createContact()
        {
            CreateContacts contacts = new CreateContacts();

            Console.WriteLine("Enter First Name: ");
            contacts.First_Name = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            contacts.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            contacts.city = Console.ReadLine();
            Console.WriteLine("Enter the State: ");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            contacts.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number: ");
            contacts.PhoneNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email Address: "); 
            contacts.Email = Console.ReadLine();
            addressBookSysytem.Add(contacts);
        }
        public void addPerson()
        {
            CreateContacts newcontact = new CreateContacts();

            Console.WriteLine("Enter First Name of Person :");
            newcontact.First_Name = Console.ReadLine();

            foreach (CreateContacts contact in addressBookSysytem)
            {
                if (contact.First_Name == newcontact.First_Name)
                {
                    Console.WriteLine("Person with this Name Already Exists");
                    return;
                }
            }
            Console.WriteLine("Enter Last Name: ");
            newcontact.Last_Name = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            newcontact.Address = Console.ReadLine();

            Console.WriteLine("Enter City Name: ");
            newcontact.city = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            newcontact.state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code: ");
            newcontact.zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            newcontact.PhoneNo = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Email-Id");
            newcontact.Email = Console.ReadLine();

            addressBookSysytem.Add(newcontact);
        }
        public void EditContact()
        {
            Console.WriteLine("Please Enter Name of Person to Edit");
            string FirstName = Console.ReadLine();

            foreach (CreateContacts contact in addressBookSysytem)
            {
                if (contact.First_Name == FirstName)
                {
                    Console.WriteLine(" please Enter Details Do You Want To Edit ");
                    Console.WriteLine("Select options to Edit Details :\n" +
                        "1.Last_Name\n" + "2.Address\n" + "3.city\n" +
                        "4. state\n" + " 5.zip Code\n" + "6.Phone Number\n" +"7.Email\n");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("Enter Last Name");
                            contact.Last_Name = Console.ReadLine();
                            break;

                        case 2:

                            Console.WriteLine("Enter Address");
                            contact.Address = Console.ReadLine();
                            break;

                        case 3:

                            Console.WriteLine("Enter City");
                            contact.city = Console.ReadLine();
                            break;

                        case 4:

                            Console.WriteLine("Enter State");
                            contact.state = Console.ReadLine();
                            break;

                        case 5:

                            Console.WriteLine("Enter Zip Code");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 6:

                            Console.WriteLine("Enter Phone Number");
                            contact.PhoneNo = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 7:

                            Console.WriteLine("Enter Email");
                            contact.Email = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Wrong Option");
                            break;

                    }

                }
                Console.WriteLine("sorry!!! Not Found");
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter Name Do You Want to Delete");
            string FirstName = Console.ReadLine();

            foreach (CreateContacts contact in addressBookSysytem)
            {
                if (contact.First_Name.ToLower() == FirstName.ToLower())
                {
                    addressBookSysytem.Remove(contact);
                    Console.WriteLine("Entered First Name is Deleted from the List");
                    return;
                }
            }
            Console.WriteLine("Contact not Found ");
        }

        public void Display()
        {
            foreach (CreateContacts contact in addressBookSysytem)
            {
                Console.WriteLine(contact.First_Name);
                Console.WriteLine(contact.Last_Name);
                Console.WriteLine(contact.Address);
                Console.WriteLine(contact.city);
                Console.WriteLine(contact.state);
                Console.WriteLine(contact.zip);
                Console.WriteLine(contact.PhoneNo);
                Console.WriteLine(contact.Email);
            }
        }
    }
}

