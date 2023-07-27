using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// librerias
using SQLite;
using codeAPP.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(SqliteClient))]

namespace codeAPP.Droid
{
    public class SqliteClient : Database
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            // creacion de la base de datos
            var path = Path.Combine(documentsPath, "uisrael.exc");
            return new SQLiteAsyncConnection(path);

        }
    }
}