using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal sealed class ListProduct
	{
		public List<string> products;

		public ListProduct()
		{
			this.products = new List<string>();
			products.Add("Milk");
			products.Add("Cream");
			products.Add("Cakes");
			products.Add("soda");
			products.Add("Coffee");
			products.Add("Latte");
			products.Add("Cocoa");
		}
	}
}
