using System;
using SQLite;

namespace exelxior
{
	public class Expense
	{
		public Expense()
		{

		}

		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public decimal Value { get; set; }
		public int CategoryId { get; set; }

		[Ignore]
		public Category Category { get; set; }
	}
}
