using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_02
{
	internal class TerminalLogger : ILogger
	{
		public void Info(string message)
		{
			Console.WriteLine($"Info: {message}");
		}

		public void Warning(string message)
		{
			Console.WriteLine($"Warning: {message}");
		}
		public void Error(string message)
		{
			Console.WriteLine($"Error {message}");
		}
	}
}
