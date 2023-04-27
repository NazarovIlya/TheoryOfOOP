using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal class Milk : Product
	{
		public Milk() : base(255, "Yaroslavka 3,2%")
		{
		}

		public override void eat()
		{
			Console.WriteLine("Nice milk!");
		}
	}
}
