using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome To AddressBook Management");

            Contacts person = new Contacts();
            AddressBook.AddContact();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.EditContact();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.DeleteContact();
            AddressBook.ContactsDisplay();
        }
    }
}