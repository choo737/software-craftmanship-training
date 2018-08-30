using DemoModel;
using System;
using System.Collections.Generic;

namespace CodeDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			Product peanutButterJam = new Product { Name = "Peanut Butter Jam", ID = 1 };
			Product myVi = new Product { Name = "MyVi", ID = 2 };
			Product strawberryJam = new Product { Name = "StrawBerry Jam", ID = 3 };
			Product chair = new Product { Name = "Chair", ID = 4 };
			Product BMW = new Product { Name = "BMW", ID = 5 };
			Product table = new Product { Name = "Table", ID = 6 };
			Product friedRice = new Product { Name = "Fried Rice", ID = 7 };

			ProductGroup vehicleGroup = new ProductGroup() { ID = 0, Name = "Vehicles" };
			ProductGroup foodAndBeverageGroup = new ProductGroup() { ID = 1, Name = "F&B" };
			ProductGroup furnitureGroup = new ProductGroup() { ID = 2, Name = "Furniture" };

			Package chineseNewYearPackage = new Package() { ID = 0, Name = "Chinese New Year Package" };
			Package rayaPackage = new Package() { ID = 1, Name = "Raya Package" };
			Package merdekaPackage = new Package() { ID = 2, Name = "Merdeka Package" };
			
			vehicleGroup.Products.Add(myVi);
			vehicleGroup.Products.Add(BMW);
			
			foodAndBeverageGroup.Products.Add(peanutButterJam);
			foodAndBeverageGroup.Products.Add(myVi);
			foodAndBeverageGroup.Products.Add(friedRice);
			
			furnitureGroup.Products.Add(chair);
			furnitureGroup.Products.Add(table);
			
			chineseNewYearPackage.Products.Add(myVi);
			chineseNewYearPackage.Products.Add(strawberryJam);
			chineseNewYearPackage.Products.Add(chair);
			
			rayaPackage.Products.Add(peanutButterJam);
			rayaPackage.Products.Add(myVi);
			rayaPackage.Products.Add(chair);
			
			merdekaPackage.Products.Add(BMW);
			merdekaPackage.Products.Add(table);
			merdekaPackage.Products.Add(friedRice);

			List<Product> allProduct = new List<Product>();
			allProduct.Add(peanutButterJam);
			allProduct.Add(myVi);
			allProduct.Add(strawberryJam);
			allProduct.Add(chair);
			allProduct.Add(BMW);
			allProduct.Add(table);
			allProduct.Add(friedRice);

			List<ProductGroup> allProductGroup = new List<ProductGroup>();
			allProductGroup.Add(vehicleGroup);
			allProductGroup.Add(foodAndBeverageGroup);
			allProductGroup.Add(furnitureGroup);

			List<Package> allPackage = new List<Package>();
			allPackage.Add(chineseNewYearPackage);
			allPackage.Add(rayaPackage);
			allPackage.Add(merdekaPackage);

			ShareFunction.GoodDisplayFunction(allProduct, allProductGroup, allPackage);
			Console.Read();
		}
	}
}
