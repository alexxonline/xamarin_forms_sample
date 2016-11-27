using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace exelxior
{
	public partial class AddExpensePage : ContentPage
	{
		public AddExpensePage()
		{
			InitializeComponent();
			InitializePicker();
		}

		private void InitializePicker()
		{
			var categories = Category.GetDefaultCategories();

			foreach (var category in categories)
			{
				CmbCategory.Items.Add(category.Name);
			}
		}

		async void OnAddExpense(object sender, EventArgs e)
		{
			decimal expense = 0;
			var canParse = decimal.TryParse(TxtExpense.Text, out expense);

			if (CmbCategory.SelectedIndex == -1)
			{
				await DisplayAlert("Pequeño problema", "Debe elegir una categoría", "Ok");
				return;
			}

			if (!canParse)
			{
				await DisplayAlert("Pequeño problema", "El número ingresado como gasto no es valido", "Ok");
				return;
			}
			var selectedCategoryName = CmbCategory.Items[CmbCategory.SelectedIndex];
			var category = Category.GetDefaultCategories().First(c => c.Name == selectedCategoryName);

			var expenseObject = new Expense
			{
				Category = category,
				Value = expense
			};
		}
	}
}
