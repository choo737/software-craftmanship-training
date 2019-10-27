using System;
using System.Collections.Generic;

namespace DemoModel
{
	public static class ShareFunction
	{
		public static void BadDisplayFunction(List<Product> pl, List<ProductGroup> pg, List<Package> pkg)
		{
			Console.WriteLine("All Product:");
			LogProducts(pl, false);
			Console.WriteLine("");

			Console.WriteLine("All Product Group:");
			LogProductGroups(pg);
			Console.WriteLine("");

			Console.WriteLine("All Package:");
			LogPackages(pkg);
			Console.WriteLine("");
		}
		
		/// <summary>
		/// Helps you to log down all the products, product groups and packages in this console application
		/// </summary>
		/// <param name="products"></param>
		/// <param name="productGroups"></param>
		/// <param name="packages"></param>
		public static void GoodDisplayFunction(List<Product> products, List<ProductGroup> productGroups, 
			List<Package> packages)
		{
			Console.WriteLine("All Product:");
			LogProducts(products, false);
			Console.WriteLine("");
			Console.WriteLine("All Product Group:");
			LogProductGroups(productGroups);
			Console.WriteLine("");
			Console.WriteLine("All Package:");
			LogPackages(packages);
			Console.WriteLine("");
		}

		/// <summary>
		/// Log product groups and its products in console
		/// </summary>
		/// <param name="productGroups"></param>
		private static void LogProductGroups(List<ProductGroup> productGroups)
		{
			Console.WriteLine("------------------------------");
			foreach (ProductGroup productGroup in productGroups)
			{
				Console.WriteLine(string.Format("{0}: {1}", productGroup.ID, productGroup.Name));
				LogProducts(productGroup.Products, true);
				Console.WriteLine("-------------------------");
			}
		}

		/// <summary>
		/// Log packages and its products in console
		/// </summary>
		/// <param name="packages"></param>
		private static void LogPackages(List<Package> packages)
		{
			Console.WriteLine("------------------------------");
			foreach (Package package in packages)
			{
				Console.WriteLine(string.Format("{0}: {1}", package.ID, package.Name));
				LogProducts(package.Products, true);
				Console.WriteLine("------------------------------");
			}
		}

		/// <summary>
		/// List all the products in console
		/// </summary>
		/// <param name="products"></param>
		/// <param name="showAsChild">true for products to be listed as child element</param>
		private static void LogProducts(List<Product> products, bool showAsChild)
		{
			foreach(Product product in products)
			{
				if (showAsChild)
				{
					Console.WriteLine(string.Format("- {0}", product.Name));
				}
				else
				{
					Console.WriteLine(string.Format("{0}: {1}", product.ID, product.Name));
				}
			}
		}
	}
}
