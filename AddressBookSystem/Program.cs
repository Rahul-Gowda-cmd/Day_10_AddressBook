using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            int option, option1;
            string bookName = "default";
            AddressBookBuilder addressBook = new AddressBookBuilder();

            Console.WriteLine("1. Would you like to work on existing addressbook ? if yes press 1");
            Console.WriteLine("2. Would you like to add  new addressbook ? if yes press 2");
            option1 = Convert.ToInt32(Console.ReadLine());
            switch (option1)
            {
                case 1:
                    addressBook.AddAddressBook(bookName);
                    break;
                case 2:
                    Console.WriteLine("Enter Name Of New Addressbook You want to create : ");
                    bookName = Console.ReadLine();
                    addressBook.AddAddressBook(bookName);
                    break;
                case 3:
                    Console.WriteLine("Enter first Name of contact which to be edited");
                    string NameToEdit = Console.ReadLine();
                    addressBook.EditContact(NameToEdit);
                    break;
                case 4:
                    Console.WriteLine("Enter Name For New AddressBook");
                    string newAddressBook = Console.ReadLine();
                    addressBook.AddAddressBook(newAddressBook);
                    Console.WriteLine("Would you like to Switch to " + newAddressBook);
                    Console.WriteLine("1.Yes \n2.No");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1)
                    {
                        bookName = newAddressBook;
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter Name Of AddressBook From Below List");
                    foreach (KeyValuePair<string, AddressBookBuilder> item in addressBook.GetAddressBook())
                    {
                        Console.WriteLine(item.Key);
                    }
                    while (true)
                    {
                        bookName = Console.ReadLine();
                        if (addressBook.GetAddressBook().ContainsKey(bookName))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No such AddressBook found. Try Again.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
            Console.WriteLine("Do you want to continue?  press 1 if yes,press 0 for Exit");
            option = Convert.ToInt32(Console.ReadLine());
        
            while (option != 0);
            }
        }
}



               
