using DemoModel;
using System;
using System.Collections.Generic;

namespace CodeDemo1
{
	class Program
	{
		static void Main(string[] args)
		{
			Product p0 = new Product { Name = "Peanut Butter Jam", ID = 1 };
			Product p1 = new Product { Name = "MyVi", ID = 2 };
			Product p2 = new Product { Name = "StrawBerry Jam", ID = 3 };
			Product p3 = new Product { Name = "Chair", ID = 4 };
			Product p4 = new Product { Name = "BMW", ID = 5 };
			Product p5 = new Product { Name = "Table", ID = 6 };
			Product p6 = new Product { Name = "Fried Rice", ID = 7 };

			ProductGroup pg0 = new ProductGroup() { ID = 0, Name = "Vehicles" };
			ProductGroup pg1 = new ProductGroup() { ID = 1, Name = "F&B" };
			ProductGroup pg2 = new ProductGroup() { ID = 2, Name = "Furniture" };

			Package pkg0 = new Package() { ID = 0, Name = "Chinese New Year Package" };
			Package pkg1 = new Package() { ID = 1, Name = "Raya Package" };
			Package pkg2 = new Package() { ID = 2, Name = "Merdeka Package" };
			
			pg0.Products.Add(p1);
			pg0.Products.Add(p4);
			
			pg1.Products.Add(p0);
			pg1.Products.Add(p1);
			pg1.Products.Add(p6);
			
			pg2.Products.Add(p3);
			pg2.Products.Add(p5);
			
			pkg0.Products.Add(p1);
			pkg0.Products.Add(p2);
			pkg0.Products.Add(p3);
			
			pkg1.Products.Add(p0);
			pkg1.Products.Add(p1);
			pkg1.Products.Add(p3);
			
			pkg2.Products.Add(p4);
			pkg2.Products.Add(p5);
			pkg2.Products.Add(p6);

			List<Product> pAll = new List<Product>();
			pAll.Add(p0);
			pAll.Add(p1);
			pAll.Add(p2);
			pAll.Add(p3);
			pAll.Add(p4);
			pAll.Add(p5);
			pAll.Add(p6);

			List<ProductGroup> pgAll = new List<ProductGroup>();
			pgAll.Add(pg0);
			pgAll.Add(pg1);
			pgAll.Add(pg2);

			List<Package> pkgAll = new List<Package>();
			pkgAll.Add(pkg0);
			pkgAll.Add(pkg1);
			pkgAll.Add(pkg2);

			ShareFunction.BadDisplayFunction(pAll, pgAll, pkgAll);
			Console.Read();
		}
	}
}
