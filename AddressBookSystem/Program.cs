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
                CreateContacts contacts = new CreateContacts()
                {
                    First_Name = "Varsha",
                    Last_Name = "Gunjal",
                    Address = "Sangamner",
                    city = "Ahmednagar",
                    state = "Maharastra",
                    zip = 422605,
                    PhoneNo = 8788583058,
                    Email = "varshagunjal01@gmail.com"
                };
                Console.WriteLine(contacts.First_Name + "\n" + contacts.Last_Name + "\n" + contacts.Address + "\n" + contacts.city + "\n"
                + contacts.state + "\n" + contacts.zip + "\n" + contacts.PhoneNo + "\n" + contacts.Email);
                Console.ReadLine();



        }
    }
}
