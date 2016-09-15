﻿using System;
using System.Collections.Generic;
using HornetsTraining.Training2.HomeWork.NBP;

namespace HornetsTraining.Training2.HomeWork
{
    public static class BankList
    {
        /// <summary>
        /// Wspólna lista banków, dopisywać swój śmiało :)
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Func<TransferHandler>> GetBankList()
        {
            var result = new Dictionary<string, Func<TransferHandler>>();
            result.Add("1010", () => new NBPTransferHandler()); 
            result.Add("1440", () => new NordeaBankTransferHandler());
            result.Add("1140", () => new MbankTransferHandler());
            result.Add("1680", () => new PlusBankTransferHandler());

            return result;
        }
    }
}