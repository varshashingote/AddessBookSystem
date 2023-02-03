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
                Console.WriteLine("Please select the Options :\n" +
                    "1)Enter Details & add Contact in List\n" +
                    "2)Add new Contact\n");

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
                        Console.WriteLine("Entered Details of Person given as :");
                        address1.Display();
                        address1.addPerson();
                        break;
                    default:
                        Console.WriteLine("Please choice correct option");
                        break;
                }
                value = false;
                break;
            }
        } 
    }
}
