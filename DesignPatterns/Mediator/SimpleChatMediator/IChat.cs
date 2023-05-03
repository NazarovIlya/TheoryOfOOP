using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChatMediator
{
	internal interface IChat
	{
		void SendMessage(string message, User user);
		void AppendUser(User user);
	}
}
