using System;

namespace AddressBookSystem_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            /// Calling CreateDataTable method from AddressBookDataTable class
            Console.WriteLine("Adding data to data table....");
            addressBookDataTable.CreateDataTable();
            /// Calling EditContact method from AddressBookDataTable class
            Console.WriteLine("Updated table..");
            addressBookDataTable.EditContact();
            /// Calling DeleteContact method from AddressBookDataTable class
            Console.WriteLine("Deleting contact...");
            addressBookDataTable.DeleteContact();
            /// Calling RetrieveDataWithCityOrState method from AddressBookDataTable class
            Console.WriteLine("Contacts with city or state name: ");
            addressBookDataTable.RetrieveDataWithCityOrState();
            /// Calling CountByCity and CountByState method from AddressBookDataTable class
            Console.WriteLine("Count by city: ");
            addressBookDataTable.CountByCity();
            Console.WriteLine("Count by state: ");
            addressBookDataTable.CountByState();
        }
    }
}
