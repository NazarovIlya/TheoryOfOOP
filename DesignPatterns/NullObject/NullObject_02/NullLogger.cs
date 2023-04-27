using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_02
{
	internal class NullLogger : ILogger
	{

		public void Info(string message)
		{
		}

		public void Warning(string message)
		{
		}
		public void Error(string message)
		{
		}
	}
}
