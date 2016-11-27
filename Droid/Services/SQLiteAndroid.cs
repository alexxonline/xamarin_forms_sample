using System;
using System.IO;
using exelxior.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteAndroid))]
namespace exelxior.Droid
{
	public class SQLiteAndroid :ISQLite
	{
		public SQLiteAndroid()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "Expenses.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);
			// Create the connection
			var conn = new SQLite.SQLiteConnection(path);
			// Return the database connection
			return conn;		
		}
	}
}
