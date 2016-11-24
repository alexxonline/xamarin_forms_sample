using System;
using System.Linq;

namespace exelxior
{
	public class AddExpenseViewModel : ViewModelBase
	{
		public AddExpenseViewModel()
		{
		}

		private decimal _value;
		public decimal Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
				OnPropertyChanged();
			}
		}

		private int? _selectedCategoryId;
		public int? SelectedCategoryId
		{
			get
			{
				return _selectedCategoryId;
			}
			set
			{
				_selectedCategoryId = value;
				OnPropertyChanged();
			}
		}

		public Expense GetExpense()
		{
			if (SelectedCategoryId == null)
			{
				return null;
			}

			var category = Category.GetDefaultCategories().FirstOrDefault(c => c.Id == this.SelectedCategoryId.Value);

			return new Expense
			{
				Category = category,
				Value = this.Value
			};
		}
	}
}
