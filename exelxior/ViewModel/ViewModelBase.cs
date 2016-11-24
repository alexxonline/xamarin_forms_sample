using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace exelxior
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public ViewModelBase()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;

			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
