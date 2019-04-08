using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace Contact_List
{
    public class ContactRepository
    {
        SQLiteConnection database;
        public ContactRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Contact>();
        }
        public IEnumerable<Contact> GetItems()
        {
            return (from i in database.Table<Contact>() select i).ToList();
        }
        public Contact GetItem(int id)
        {
            return database.Get<Contact>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Contact>(id);
        }
        public int SaveItem(Contact item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
