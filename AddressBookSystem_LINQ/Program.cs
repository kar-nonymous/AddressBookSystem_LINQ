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
        }
    }
}
