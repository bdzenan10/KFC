using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using KFC.Data;
using KFC.Droid.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Xamarin.Forms;
using System.Text;
[assembly: Dependency(typeof(SQLLite_Android))]
namespace KFC.Droid.Data
{
    public class SQLLite_Android : SQLlite
    {

        public SQLLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqlLiteFileName = "Test.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqlLiteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}