using SimpleChatMediator;
Console.WriteLine("CHAT");

ChatMediator chat = new();

User user1 = new User(chat, "user1");
User user2 = new User(chat, "user2");
User user3 = new User(chat, "user3");

chat.AppendUser(user1);
user1.SendMessage("I'm user 1");

chat.AppendUser(user2);
user2.SendMessage("I'm user 2");

chat.AppendUser(user3);
user3.SendMessage("I'm user 3");

user1.SendMessage("Hi, everyone! I'm user 1");