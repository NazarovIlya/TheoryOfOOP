using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_01
{
	internal class ProductNotFoundExeption : Exception
	{
		public ProductNotFoundExeption(string? message) : base(message)
		{
		}
	}
}
