using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public List<CreateContacts> addressBookSysyem = new List<CreateContacts>();
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
            addressBookSysyem.Add(contacts);
        }
        public void addPerson()
        {
            CreateContacts newcontact = new CreateContacts();

            Console.WriteLine("Enter First Name of Person :");
            newcontact.First_Name = Console.ReadLine();

            foreach (CreateContacts contact in addressBookSysyem)
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

            addressBookSysyem.Add(newcontact);
        }
        public void Display()
        {
            foreach (CreateContacts contact in addressBookSysyem)
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

