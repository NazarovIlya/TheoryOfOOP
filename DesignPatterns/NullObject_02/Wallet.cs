using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_02
{
	internal class Wallet
	{
		private ILogger logger;
		private int balance;
		
		public Wallet(ILogger logger)
		{
			this.logger = logger;
		}

		public int GetBalance()
		{
			return balance;
		}
		public void DepositMoney(int amount)
		{
				balance += amount;
            if (logger != null)
            {
				logger.Warning($"Пополнение на {amount}");
            }
        }
	}
}
