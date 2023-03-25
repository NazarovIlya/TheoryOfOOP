using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal abstract class Product
	{
		protected int energy;
		protected string name;

		protected Product(int energy, string name)
		{
			this.energy = energy;
			this.name = name;
		}

		public abstract void eat();
		public virtual string KCalOfProduct()
		{
			return string.Format("Energy value: {0} is {1} kcal.", this.name, this.energy);
		}
	}
}
