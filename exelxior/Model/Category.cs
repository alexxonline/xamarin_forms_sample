using System;
using System.Collections.Generic;

namespace exelxior
{
	public class Category
	{
		public Category()
		{

		}

		public int Id { get; set; }

		public string Name
		{
			get;
			set;
		}

		public static List<Category> GetDefaultCategories()
		{
			var list = new List<Category>();
			list.Add(new Category
			{
				Id = 1,
				Name = "Comida"
			});

			list.Add(new Category
			{
				Id = 2,
				Name = "Combustible"
			});

			list.Add(new Category
			{
				Id = 3,
				Name = "Impuestos"
			});

			list.Add(new Category
			{
				Id = 4,
				Name = "Entretenimiento"
			});

			list.Add(new Category
			{
				Id = 5,
				Name = "Estudio"
			});

			list.Add(new Category
			{
				Id = 6,
				Name = "Otros"
			});

			return list;
		}
	}
}
