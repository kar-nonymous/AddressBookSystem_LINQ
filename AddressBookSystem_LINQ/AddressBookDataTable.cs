using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookSystem_LINQ
{
    class AddressBookDataTable
    {
        public DataTable addressTable = new DataTable();
        /// <summary>
        /// UC 2,3: 
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
        /// <summary>
        /// UC4: 
        /// Edit contact
        /// </summary>
        public void EditContact()
        {
            var recordedData = addressTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Kumar").FirstOrDefault();
            recordedData["Zip"] = "281001";
            Console.WriteLine("FirstName: " + recordedData.Field<string>("FirstName") + " LastName: " + recordedData.Field<string>("LastName") + " Address: " + recordedData.Field<string>("Address") + " City: " + recordedData.Field<string>("City") + " State: " + recordedData.Field<string>("State"));
        }
        /// <summary>
        /// UC5 :
        /// Deletes contact
        /// </summary>
        public void DeleteContact()
        {
            var recordedData = addressTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Shashank").FirstOrDefault();
            recordedData.Delete();
        }
    }
}
