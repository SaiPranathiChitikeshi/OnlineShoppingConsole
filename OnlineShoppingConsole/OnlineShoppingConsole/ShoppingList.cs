using System;
using System.Collections.Generic;
namespace OnlineShoppingConsole
{
	public class ShoppingList
	{
		public List<ShoppingCategories> ShoppingLi = new List<ShoppingCategories>();
		public List<ShoppingCategories> ShoppingLi1 = new List<ShoppingCategories>();
		public List<ShoppingCategories> ShoppingLi2 = new List<ShoppingCategories>();
		public List<ShoppingCategories> Men()
        {
			ShoppingLi.Add(new ShoppingCategories() { clothes = "shirts", shoes = "shoes", accessories = "belt" });
			ShoppingLi.Add(new ShoppingCategories() { clothes = "trousers", shoes = "slippers", accessories = "watch" });
			ShoppingLi.Add(new ShoppingCategories() { clothes = "jackets", shoes = "sandals", accessories = "rings" });
			
			//string re = string.Join(",", ShoppingLi.ToString());
			foreach(var i in ShoppingLi)
            {
				Console.WriteLine(i.ToString());
            }
			return ShoppingLi;
        }
		public List<ShoppingCategories> Women()
		{

			ShoppingLi1.Add(new ShoppingCategories() { Clothes = "western", Shoes = "flipflops", Accessories = "earings" });
			ShoppingLi1.Add(new ShoppingCategories() { Clothes = "traditional", Shoes = "sliders", Accessories = "bracelet" });
			ShoppingLi1.Add(new ShoppingCategories() { Clothes = "maxi", Shoes = "heels", Accessories = "hairpin" });
			foreach (var i in ShoppingLi1)
			{
				Console.WriteLine(i.ToString());
			}

			return ShoppingLi1;
		}
		public List<ShoppingCategories> Cosmetics()
		{

			ShoppingLi2.Add(new ShoppingCategories() { kajol = "lakme", liner = "lakmeabs", lipstick = "red" });
			ShoppingLi2.Add(new ShoppingCategories() { kajol = "himalaya", liner = "colorbar", lipstick = "pink" });
			ShoppingLi2.Add(new ShoppingCategories() { kajol = "Mac", liner = "maybelline", lipstick = "orange" });
			foreach (var i in ShoppingLi2)
			{
				Console.WriteLine(i.ToString());
			}

			return ShoppingLi2;
		}

		//public static List<ShoppingCategories>
	}
}
