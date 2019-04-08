using System;
using System.IO;
using Contact_List.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Contact_List.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        // определяем путь к бд
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}