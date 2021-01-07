using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
namespace OnlineShoppingConsole
{

	public class ShoppingListLinq
	{
		public  List<ShoppingCategories> Menorder(List<ShoppingCategories> Lis) {
			List<ShoppingCategories> or = (from ShoppingList in Lis
					 orderby ShoppingList.clothes
					 select ShoppingList).ToList();
			foreach(var lis in or)
            {
				Console.WriteLine($"Men's things{lis}");
            }
			return or;

		}
		public List<ShoppingCategories> Womenorder(List<ShoppingCategories> Lis)
		{
			List<ShoppingCategories> or = (from ShoppingList in Lis
					 orderby ShoppingList.Clothes
					 select ShoppingList).ToList();
			foreach (var lis in or)
			{
				Console.WriteLine($"Women's things{lis}");
			}
			return or;
		}
		public List<ShoppingCategories> Cosmeticsorder(List<ShoppingCategories> Lis)
		{
			List<ShoppingCategories> or = (from ShoppingList in Lis
					 orderby ShoppingList.Clothes
					 select ShoppingList).ToList();
			foreach (var lis in or)
			{
				Console.WriteLine($"Cosmetics are up {lis}");
			}
			return or;
		}
	}
}
