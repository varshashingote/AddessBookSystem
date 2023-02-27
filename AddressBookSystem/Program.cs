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
            Console.Clear();
            Console.WriteLine("Welcome to Address Book Program\n");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please select given options:\n");
                Console.WriteLine("1.AddContacts\n2.DisplayDetails\n17.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBook.AddContacts();
                        Console.Clear();
                        break;
                    case 2:
                        AddressBook.DisplayDetails();
                        Console.Clear();
                        break;
                    case 17:
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only give options");
                        break;
                }
            }
        }
    }
}
       



    

















