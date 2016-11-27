using System;
using System.IO;
using exelxior.iOS;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteIos))]
namespace exelxior.iOS
{
	public class SQLiteIos :ISQLite
	{
		public SQLiteIos()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "Expenses.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);
			// Create the connection
			var conn = new SQLite.SQLiteConnection(path);
			// Return the database connection
			return conn;		
		}
	}
}
