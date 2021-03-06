﻿using System;
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
        /// UC 5:
        /// Deletes contact
        /// </summary>
        public void DeleteContact()
        {
            var recordedData = addressTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Shashank").FirstOrDefault();
            recordedData.Delete();
        }
        /// <summary>
        /// UC 6:
        /// Retrieves data with city or state name
        /// </summary>
        public void RetrieveDataWithCityOrState()
        {
            var recordedData = from contacts in addressTable.AsEnumerable()
                               where (contacts.Field<string>("City") == "Agra" || contacts.Field<string>("State") == "UP")
                               select contacts;
            foreach (var contact in recordedData)
            {
                Console.WriteLine("FirstName: " + contact.Field<string>("FirstName") + " LastName: " + contact.Field<string>("LastName") + " Address: " + contact.Field<string>("Address") + " City: " + contact.Field<string>("City") + " State: " + contact.Field<string>("State"));
            }
        }
        /// <summary>
        /// UC 7:
        /// Counts by city
        /// </summary>
        public void CountByCity()
        {
            var recordedData = addressTable.AsEnumerable().GroupBy(r => r.Field<string>("City")).Select(x => new { City = x.Key, Count = x.Count() });
            foreach (var contact in recordedData)
            {
                Console.WriteLine("City: " + contact.City + " Count: " + contact.Count);
            }
        }
        /// <summary>
        /// UC 7:
        /// Counts by state
        /// </summary>
        public void CountByState()
        {
            var recordedData = addressTable.AsEnumerable().GroupBy(r => r.Field<string>("State")).Select(x => new { State = x.Key, Count = x.Count() });
            foreach (var contact in recordedData)
            {
                Console.WriteLine("State: " + contact.State + " Count: " + contact.Count);
            }
        }
    }
}
