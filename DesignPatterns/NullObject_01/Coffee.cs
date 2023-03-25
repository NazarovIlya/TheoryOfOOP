using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal class Coffee : Product
	{
		public Coffee() : base(78, "Bridge. Black coffee.")
		{
		}

		public override void eat()
		{
			Console.WriteLine("Invigorating drink");
		}
	}
}
