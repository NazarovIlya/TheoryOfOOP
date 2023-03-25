using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal class Cake : Product
	{
		public Cake() : base(578, "Yashkino.")
		{
		}

		public override void eat()
		{
			Console.WriteLine("Sweet cakes!");
		}
	}
}
