﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17FinPractice
{
    public class OrdinaryCalculator : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance  >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
