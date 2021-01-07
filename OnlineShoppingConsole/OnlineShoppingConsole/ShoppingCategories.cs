using System;
using System.Collections.Generic;
using System.Linq;
namespace OnlineShoppingConsole
{

    interface men
    {
        public abstract string clothes();
        public abstract string shoes();
        public abstract string accessories();
    }
    interface women
    {


        public abstract string Clothes();
        public abstract string Shoes();
        public abstract string Accessories();
    }
    interface cosmetics
    {
        public abstract string kajol();
        public abstract string liner();
        public abstract string lipstick();
    }



    public class ShoppingCategories
    {
        public string clothes { get; internal set; }
        public string Clothes { get; internal set; }
        public string shoes { get; internal set; }
        public string Shoes { get; internal set; }
        public string accessories { get; internal set; }
        public string Accessories { get; internal set; }
        public string kajol { get; internal set; }
        public string liner { get; internal set; }
        public string lipstick { get; internal set; }

        public class Men : men
        {
            ShoppingList sl = new ShoppingList();
            public string accessories()
            {
                //Console.WriteLine( sl.Men());
                foreach(var i in sl.Men())
                {
                    Console.WriteLine(i.ToString());
                }

                throw new NotImplementedException();
            }

            public string clothes()
            {
                //sl.Men();
                foreach (var i in sl.Men())
                {
                    Console.WriteLine(i.ToString());
                }
                throw new NotImplementedException();
            }

            public string shoes()
            {
                //sl.Men();
                foreach (var i in sl.Men())
                {
                    Console.WriteLine(i.ToString());
                }
                throw new NotImplementedException();
            }
        }
        public class Women : women
        {
            ShoppingList sl = new ShoppingList();
            public string Accessories()
            {
                sl.Women();
                throw new NotImplementedException();
            }

            public string Clothes()
            {
                sl.Women();
                throw new NotImplementedException();
            }

            public string Shoes()
            {
                sl.Women();
                throw new NotImplementedException();
            }
        }
        public class Cosmetics : cosmetics
        {
            ShoppingList sl = new ShoppingList();
            public string kajol()
            {
                sl.Cosmetics();
                throw new NotImplementedException();
            }

            public string liner()
            {
                sl.Cosmetics();
                throw new NotImplementedException();
            }

            public string lipstick()
            {
                sl.Cosmetics();
                throw new NotImplementedException();
            }
        }

        /*public string clothes { get; set; }
		public string shoes { get; set; }
		public string accessories { get; set; }
		
		public string Clothes { get; set; }
		public string Shoes { get; set; }
		public string Accessories { get; set; }
		
		public string kajol { get; set; }
		public string liner { get; set; }
		public string lipstick { get; set; }
        public override string ToString()
        {
			return Men.ToString();
        }

    }*/

    }
}