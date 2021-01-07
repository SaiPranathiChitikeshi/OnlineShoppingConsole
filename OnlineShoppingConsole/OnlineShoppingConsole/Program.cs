using System;
using System.Collections.Generic;
using System.Text;
namespace OnlineShoppingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!  Welcome to  Pranathi's Online shopping");
            ShoppingListLinq shl = new ShoppingListLinq();
            ShoppingList sh = new ShoppingList();
            ShoppingCategories shc = new ShoppingCategories();
            string str = "yes";
            while (str.Equals("yes")){
                Console.WriteLine("1.Men 2.Women 3.Cosmetics");
                try
                {
                    int cate = Convert.ToInt32(Console.ReadLine());
                    switch (cate)
                    {
                        case 1:
                            Console.WriteLine("men");
                            Console.WriteLine(shl.Menorder(sh.ShoppingLi).ToString());
                            foreach(var i in shl.Menorder(sh.ShoppingLi))
                            {
                                Console.WriteLine(i.ToString());
                            }
                            Console.WriteLine((sh.Men().ToString()));
                            foreach (var j in sh.Men())
                            {
                                Console.WriteLine(j.ToString());
                            }
                            
                            break;
                        case 2:
                            Console.WriteLine("women");
                            Console.WriteLine(shl.Womenorder(sh.ShoppingLi1));
                            Console.WriteLine(sh.Women());
                            break;
                        case 3:
                            Console.WriteLine("cosmetics");
                            Console.WriteLine(shl.Cosmeticsorder(sh.ShoppingLi2));
                            Console.WriteLine(sh.Cosmetics());
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("please, Enter valid category");
                       
                }
            }
        }
    }
}
