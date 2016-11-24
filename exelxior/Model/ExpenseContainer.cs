using System;
using System.Collections.ObjectModel;

namespace exelxior
{
	public class ExpenseContainer
	{
		public ExpenseContainer()
		{
			Expenses = new ObservableCollection<Expense>();
		}

		public ObservableCollection<Expense> Expenses { get; set; }
	}
}
