using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal class Shop
	{
		public static Product GetProductOf(string name)
		{
			switch (name.ToLower())
			{
				case "milk":
				case "cream":
					return new Milk();
				case "coffee":
				case "latte":
					return new Coffee();
				case "cakes":
					return new Cake();
				default:
					throw new Exception("Нет совпадения по наименованию товара.");
			}
		}
	}
}
