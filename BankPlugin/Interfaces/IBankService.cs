﻿using BankPlugin.BankObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPlugin
{
    public interface IBankService
    {
        bool DepositMoney(ulong steamid, long amount);
        bool WithdrawMoney(ulong steamid, long amount);

        Account CreateAccount(ulong steamid, long balance);
        long GetBalance(ulong steamId);

        List<Account> GetAllAccounts();
        Account GetAccount(ulong steamid);
    }
}
