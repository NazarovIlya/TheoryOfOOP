using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal class UnknownProduct : Product
	{
		public UnknownProduct() : base(0, "Неизвестный продукт")
		{
		}

		public override void eat()
		{
			Console.WriteLine("Продукт не найден.");
		}
	}
}
