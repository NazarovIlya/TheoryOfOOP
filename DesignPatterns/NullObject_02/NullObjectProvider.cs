using ImpromptuInterface;
using Microsoft.Extensions.DiagnosticAdapter.Infrastructure;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_02
{
	internal class NullObjectProvider<T> : DynamicObject
		where T : class
	{
		public static T GetObject
		{
			get
			{
				if (!typeof(T).IsInterface)
				{
					throw new ArgumentException("Incorrect type");
				}
				return new NullObjectProvider<T>().ActLike<T>();
			}
		}
		public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
		{
			result = Activator.CreateInstance(binder.ReturnType);
			return true;
		}
	}
}


