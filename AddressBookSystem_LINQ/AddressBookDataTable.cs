using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookSystem_LINQ
{
    class AddressBookDataTable
    {
        DataTable addressTable = new DataTable();
        /// <summary>
        /// UC 1,2: 
        /// Create data table and adding data to it
        /// </summary>
        public void CreateDataTable()
        {
            addressTable.Columns.Add("FirstName");
            addressTable.Columns.Add("LastName");
            addressTable.Columns.Add("Address");
            addressTable.Columns.Add("City");
            addressTable.Columns.Add("State");
            addressTable.Columns.Add("Zip");
            addressTable.Columns.Add("PhoneNo");
            addressTable.Columns.Add("Email");
            addressTable.Rows.Add("Kumar", "Kartikeya", "Techman City", "Agra", "UP", "281006", "7206183244", "kumar.kartikeya@capgemini.com");
            addressTable.Rows.Add("Nitigya", "Kumar", "KGMC", "Lucknow", "UP", "284001", "8265800789", "nitigya@gmail.com");
            addressTable.Rows.Add("Shashank", "Singh", "Techman City", "Agra", "UP", "281006", "7412589630", "shashank@gmail.com");
        }
    }
}
