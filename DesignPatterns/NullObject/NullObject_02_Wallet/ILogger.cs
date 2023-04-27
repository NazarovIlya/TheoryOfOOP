using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_02
{
	internal interface ILogger
	{
		void Info(string message);
		void Warning(string message);
		void Error(string message);
	}
}
