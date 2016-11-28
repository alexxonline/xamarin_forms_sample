using System;
using System.Linq;
using Xamarin.Forms;

namespace exelxior
{
	public partial class exelxiorPage : ContentPage
	{
		private readonly MainViewModel ViewModel;
		public exelxiorPage()
		{
			InitializeComponent();
			ViewModel = new MainViewModel();
			ViewModel.TotalExpenseCount = 7;
			this.BindingContext = ViewModel;

		}

		async void OnAddExpense(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AddExpensePage());
		}

		async void OnExpenseList(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ExpenseListPage());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var expenseRepository = new ExpenseRepository();
			var expenses = expenseRepository.GetExpenses();
			this.ViewModel.TotalExpenseCount = expenses.Sum(e => e.Value);
		}
	}
}
