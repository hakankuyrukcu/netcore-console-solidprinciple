﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.SingleResponsibility.Services
{
    public class AccountService
    {
        public void DepositMoney(Guid accountId, decimal amount)
        {
            Console.WriteLine($"{amount} has been deposited to {accountId}");
        }
        public void WithdrawMoney(Guid accountId, decimal amount)
        {
            Console.WriteLine($"{amount} has been withdrawn from {accountId}");
        }
    }
}
