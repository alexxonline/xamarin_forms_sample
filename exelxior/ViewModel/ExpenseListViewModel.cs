using System;
using System.Collections.ObjectModel;

namespace exelxior
{
	public class ExpenseListViewModel : ViewModelBase
	{
		public ExpenseListViewModel()
		{
			Expenses = new ObservableCollection<Expense>();
		}

		public ObservableCollection<Expense> Expenses { get; set; }

	}
}
