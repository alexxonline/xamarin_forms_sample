using System;
namespace exelxior
{
	public class MainViewModel : ViewModelBase
	{
		public MainViewModel()
		{
		}

		private decimal _totalExpenseCount;
		public decimal TotalExpenseCount
		{
			get
			{
				return _totalExpenseCount;
			}

			set
			{
				_totalExpenseCount = value;
				OnPropertyChanged();
				OnPropertyChanged("TotalExpenseCountFormatted");
			}
		}

		public string TotalExpenseCountFormatted
		{
			get
			{
				return TotalExpenseCount.ToString("C");
			}
		}
	}
}
