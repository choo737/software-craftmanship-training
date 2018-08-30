using System;
using System.Collections.Generic;
using System.Text;

namespace DemoModel
{
	public class Package
	{
		public string Name { get; set; }
		public int ID { get; set; }
		public List<Product> Products { get; set; }

		public Package()
		{
			Products = new List<Product>();
		}
	}

	public class ProductGroup
	{
		public string Name { get; set; }
		public int ID { get; set; }
		public List<Product> Products { get; set; }

		public ProductGroup() {
			Products = new List<Product>();
		}
	}

	public class Product
	{
		public string Name { get; set; }
		public int ID { get; set; }
	}
}