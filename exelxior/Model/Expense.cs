using System;
namespace exelxior
{
	public class Expense
	{
		public Expense()
		{

		}

		public int Id { get; set; }
		public decimal Value { get; set; }
		public Category Category { get; set; }
	}
}
