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
                Console.WriteLine("1.AddContacts\n2.DisplayDetails\n3.EditContact" +
                    "\n4 DeleteContact \n5 AddMultipleUser\n6.CreateDictionaryContacts" +
                    "\n7.DisplayDictionaryList \n8 CheckDuplicateEntry" +
                    "\n9 SearchPersonByCityOrState \n10 ViewPersonByCityOrState" +
                    "\n11 CountCityOrState \n 12 SortPersonsName" +
                    "\n13 SortPersonByCityStateOrZip \n17.Exit\n");
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
                    case 3:
                        AddressBook.EditPersonDetails();
                        Console.Clear();
                        break;
                    case 4:
                        AddressBook.DeletePersonByUsingPersonName();
                        Console.Clear();
                        break;
                    case 5:
                        AddressBook.AddMultiplePerson();
                        Console.Clear();
                        break;
                    case 6:
                        AddressBook.CreateDictionaryContacts();
                        Console.Clear();
                        break;
                    case 7:
                        AddressBook.DisplayDictionaryList();
                        Console.Clear();
                        break;
                    case 8:
                        AddressBook.CheckDuplicateEntryOfSamePersonByName();
                        Console.Clear();
                        break;
                    case 9:
                        AddressBook.SearchPersonByCityOrState();
                        Console.Clear();
                        break;
                    case 10:
                        AddressBook.ViewPersonByCityOrState();
                        Console.Clear();
                        break;
                    case 11:
                        AddressBook.CountCityOrState();
                        Console.Clear();
                        break;
                    case 12:
                        AddressBook.SortPersonsName();
                        Console.Clear();
                        break;
                    case 17:
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    case 13:
                        AddressBook.SortPersonByCityStateOrZip();
                        Console.Clear();
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
       



    

















