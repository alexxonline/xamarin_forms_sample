using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace exelxior
{
	public class ExpenseRepository
	{
		private readonly SQLiteConnection Database;
		public ExpenseRepository()
		{
			Database = DependencyService.Get<ISQLite>().GetConnection();
			Database.CreateTable<Expense>();
		}

		public IEnumerable<Expense> GetExpenses()
		{
			return Database.Table<Expense>().ToList();
		}

		public int DeleteItem(int id)
		{
			return Database.Delete<Expense>(id);
		}

		public int AddItem(Expense expense)
		{
			return Database.Insert(expense);
		}
	}
}
