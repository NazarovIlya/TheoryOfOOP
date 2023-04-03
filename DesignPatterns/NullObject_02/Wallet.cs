using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.MediaFramework.GStreamer.AudioEffects;

namespace NullObject_02
{
	internal class Wallet
	{
		private ILogger logger;
		private int balance;
		public int Balance => balance;
		public Wallet(ILogger logger) => this.logger = logger;
		public void DepositMoney(int amount)
		{
				balance += amount;
				logger.Warning($"Пополнение на {amount}");
		}
	}
}
