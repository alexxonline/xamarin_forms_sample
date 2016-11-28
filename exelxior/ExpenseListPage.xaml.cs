using System;
using System.Linq;
using System.Collections.Generic;

using Xamarin.Forms;

namespace exelxior
{
	public partial class ExpenseListPage : ContentPage
	{
		private readonly ExpenseListViewModel ViewModel;
		public ExpenseListPage()
		{
			InitializeComponent();
			ViewModel = new ExpenseListViewModel();
			this.BindingContext = ViewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			LoadList();
		}

		public void OnDelete(object sender, EventArgs e)
		{
			var mi = ((MenuItem)sender);
			var item = mi.CommandParameter;
			var expenseRepository = new ExpenseRepository();
			expenseRepository.DeleteItem(((Expense)item).Id);
			LoadList();
		}

		private void LoadList()
		{
			var expenseRepository = new ExpenseRepository();
			var expenses = expenseRepository.GetExpenses();
			ViewModel.Expenses.Clear();
			var categories = Category.GetDefaultCategories();
			foreach (var exp in expenses)
			{
				exp.Category = categories.FirstOrDefault(cat => cat.Id == exp.CategoryId);
				ViewModel.Expenses.Add(exp);

			}
		}
	}
}
