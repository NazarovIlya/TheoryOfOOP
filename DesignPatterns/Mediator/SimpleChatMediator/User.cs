using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChatMediator
{
	internal class User
	{
		private IChat chatroom;
		private string nickname;
		public string Nickname => nickname;

		public User(IChat chatroom, string nickname)
		{
			this.chatroom = chatroom;
			this.nickname = nickname;
		}
		public void SendMessage(string message)
		{
			chatroom.SendMessage(message, this);
		}
		public void PrintMessage(string message)
		{
			Console.WriteLine($"{nickname}: {message}");
		}
	}
}
