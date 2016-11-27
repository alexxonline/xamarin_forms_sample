using System;
using Xamarin.Forms;

namespace exelxior
{
	public partial class exelxiorPage : ContentPage
	{
		public exelxiorPage()
		{
			InitializeComponent();
		}

		async void OnAddExpense(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AddExpensePage());
		}

		async void OnExpenseList(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ExpenseListPage());
		}
	}
}
