using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
     class AddressBook
    {
        public List<CreateContacts> addressBookSysytem = new List<CreateContacts>();
        Dictionary<string, List<CreateContacts>> book = new Dictionary< string,List<CreateContacts>>();
        public void NewUser()
        {
            Console.WriteLine("Enter the book Name:");
            String Bookname = Console.ReadLine();
            Console.WriteLine("Enter the Number of constants to add");
            int no = Convert.ToInt32(Console.ReadLine());
            while(no>0)
            {
                no--;
                addPerson();
            }
        }
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
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter Number of contact to Add");

            int Number = Convert.ToInt32(Console.ReadLine());
            //while loop is used to store contacts which user input as a number

            while (Number > 0)
            {

                addPerson();
                Number--;
            }
        }


        //Any will check for duplicate same firstnamename in database
        public  void CheckDuplicate()
        {

            Console.WriteLine("Enter first name to which you want to  check duplicate entry ");
            string name = Console.ReadLine();
            bool check = addressBookSysytem.Any(s => s.First_Name.ToLower() == name.ToLower());
            if (check)
            {
                Console.WriteLine("contact Exists");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("In address book ==> {0} is not present \n So we add this person in contact\n just press enter and fill all details..");
                Console.ReadLine();
               addPerson();
            }
        }
        public  void SearchPersonByCityOrState()
        {
            Console.Clear();
            Console.WriteLine("First select options:--");
            Console.WriteLine("1.Search Person In City\n2.Search Person In State\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter that City name where want to search the person name ");
                    string cityName = Console.ReadLine();
                    Console.WriteLine("Enter person name that you want to search in City ");
                    string cityPersonName = Console.ReadLine();
                    foreach (var pair in book.Keys)
                    {
                        Console.WriteLine("Address Book Name: " + pair);
                        foreach (var data in addressBookSysytem.FindAll(e => e.city.ToLower() == cityName.ToLower() && e.First_Name.ToLower() == cityPersonName.ToLower()).ToList())
                        {
                            Console.WriteLine("The Contact Details of " + data.city + " are:\n--------------------------" + "\nFirstName: " + data.First_Name + " " + "\nLastName: " + data.Last_Name + " " + "\nZipcode: " + data.zip + " " + "\nPhoneNumber: " + data.PhoneNo);
                            Console.WriteLine("\nPress any key to continue....");
                            return;
                        }
                    }
                    Console.WriteLine("Person With Name ==> {0} is not found in the AddressBook in City ==> {1}", cityPersonName, cityName);
                    Console.WriteLine("\nPress any key to continue.....");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter that State name where want to search the person name ");
                    string stateName = Console.ReadLine();
                    Console.WriteLine("Enter person name that you want to search in State ");
                    string statePersonName = Console.ReadLine();
                    foreach (var pair in book.Keys)
                    {
                        Console.WriteLine("Address Book Name " + pair);
                        foreach (var data in addressBookSysytem.FindAll(e => e.state.ToLower() == stateName.ToLower() && e.First_Name.ToLower() == statePersonName.ToLower()).ToList())
                        {
                            Console.WriteLine("The Contact Details of " + data.state + " are:\n-------------------------" + "\nFirstName: " + data.First_Name + " " + "\nLastName: " + data.Last_Name + " " + "\nZipcode: " + data.zip + " " + "\nPhoneNumber: " + data.PhoneNo);
                            Console.WriteLine("\nPress any key to continue....");
                            return;
                        }
                    }
                    Console.WriteLine("Person With Name ==> {0} is not found in the AddressBook in State ==> {1}", statePersonName, stateName);
                    Console.WriteLine("\nPress any key to continue.....");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("select only valid options");
                    break;
            }
            Console.ReadLine();
        }

        public  void ViewPersonByCityOrState()
        {
            Console.Clear();
            Console.WriteLine("First select options:--");
            Console.WriteLine("1.View Person In City\n2.View Person In State\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter that City name where want to view the person name ");
                    string cityName = Console.ReadLine();
                    foreach (var pair in book.Keys)
                    {
                        Console.WriteLine("Address Book Name: " + pair);
                        Console.WriteLine("The Contact Details of {0} are:\n--------------------------", cityName);
                        foreach (CreateContacts data in addressBookSysytem.FindAll(s => s.city.ToLower() == cityName.ToLower()).ToList())
                        {
                            Console.WriteLine("\nFirstName: " + data.First_Name + " " +
                                "\nLastName: " + data.Last_Name + " " +
                                "\nZipcode: " + data.zip + " " +
                                "\nAddress: " + data.Address + " " +
                                "\nStateName: " + data.state + " " +
                                "\nPhoneNumber: " + data.PhoneNo);
                            Console.Write("-------------------------------------------");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter that State name where want to view the person name ");
                    string stateName = Console.ReadLine();
                    foreach (var pair in book.Keys)
                    {
                        Console.WriteLine("Address Book Name: " + pair);
                        Console.WriteLine("The Contact Details of {0} are:\n--------------------------", stateName);
                        foreach (CreateContacts data in addressBookSysytem.FindAll(s => s.state.ToLower() == stateName.ToLower()).ToList())
                        {
                            Console.WriteLine("\nFirstName: " + data.First_Name + " " +
                                "\nLastName: " + data.Last_Name + " " +
                                "\nZipcode: " + data.zip + " " +
                                "\nAddress: " + data.Address+ " " +
                                "\nStateName: " + data.state + " " +
                                "\nPhoneNumber: " + data.PhoneNo);
                            Console.Write("-------------------------------------------");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("select only valid options");
                    break;
            }
            Console.ReadLine();
        }


        public void CountCityOrState()
        {
            Console.Clear();
            Console.WriteLine("Enter the CityOrState name that want to count ");
            string cityOrState = Console.ReadLine();
            foreach (var data in addressBookSysytem)
            {
                if (addressBookSysytem.Contains(data))
                {
                    if (data.city.ToLower() == cityOrState.ToLower())
                    {
                        var values = addressBookSysytem.Count(x => x.city.ToLower() == cityOrState.ToLower());
                        Console.WriteLine("In {0} total number of person: {1}", cityOrState, values);
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        if (data.state == cityOrState)
                        {
                            var values = addressBookSysytem.Count(x => x.state.ToLower() == cityOrState.ToLower());
                            Console.WriteLine("In {0} total number of person: {1}", cityOrState, values);
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("In {0} no person is present", cityOrState);
                    //Console.ReadLine();
                    return;
                }

            }
        }

        public  void SortPersonsName()
        {
            Console.Clear();
            var values = addressBookSysytem.OrderBy(x => x.First_Name.ToLower()).ToList();
            Console.WriteLine("Sort person name in alphabetically");
            Console.WriteLine("-------------------------------------");
            foreach (var result in values)
            {
                Console.WriteLine("FirstName:" + result.First_Name + "   " +
                               "LastName: " + result.Last_Name + "   " +
                                "Zipcode: " + result.zip + "   " +
                                "Address: " + result.Address + "   " +
                                "StateName: " + result.state + "   " +
                                "PhoneNumber: " + result.PhoneNo);
            }
            Console.ReadLine();
        }
        public  void SortPersonByCityStateOrZip()
        {
            Console.Clear();
            var citysort = addressBookSysytem.OrderBy(x => x.city.ToLower()).ToList();
            var statesort = addressBookSysytem.OrderBy(x => x.state.ToLower()).ToList();
            var zipcodesort = addressBookSysytem.OrderBy(x => x.zip).ToList();
            Console.WriteLine("Sort person name by city name");
            Console.WriteLine("--------------------------------------");
            foreach (var result in citysort)
            {
                Console.WriteLine("CityName:" + result.city + "    " + "FirstName:" + result.First_Name);
            }
            Console.WriteLine("Sort person name by state name");
            Console.WriteLine("-----------------------------------");
            foreach (var result in statesort)
            {
                Console.WriteLine("StateName:" + result.state + "    " + "FirstName" + result.First_Name);
            }
            Console.WriteLine("Sort person name by zipcoad");
            Console.WriteLine("----------------------------------");
            foreach (var result in zipcodesort)
            {
                Console.WriteLine("ZipCode:" + result.zip + "     " + "FirstName:" + result.First_Name);
            }
            Console.ReadLine();
        }

        public  void ReadWritePersonContactsByUsingFileIO()
        {
            //Write in  file
            Console.Clear();
            string filePath = @"C:\Users\SHIVNERI\source\repos\AddressBookSystem\AddressBookSystem\PersonDetail.txt";
            StreamWriter writer = new StreamWriter(filePath);
            foreach (var data in addressBookSysytem)
            {
                writer.WriteLine("FirstName: " + data.First_Name + "    " + "\nLastName: " + data.Last_Name + "    " + "\nAddress: " + data.Address + "    " + "\nCityName: " + data.city + "    " + "\nStateName: " + data.state + "    " + "\nZipCode: " + data.zip + "    " + "\nPhoneNumber: " + data.PhoneNo + "    " + "\nEmailId: " + data.Email + "\n------------------------------------");
            }
            writer.Close();
            //Read from file
            StreamReader reader = new StreamReader(filePath);
            Console.WriteLine(reader.ReadToEnd());
            Console.ReadLine();
            Console.WriteLine("Press any key to continue.");
            reader.Close();
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

