﻿using System;
using System.Collections.Generic;
using HornetsTraining.Training1.Generics.Factory;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using HornetsTraining.Training2.HomeWork.Mbank;
using HornetsTraining.Training2.HomeWork.MichalMazur;

namespace HornetsTraining.Training2.HomeWork.Ing
{
    public class IngTransferHandlerFactory : DelegateFactoryBase<TransferHandler>
    {
        public IngTransferHandlerFactory()
        {
            ListOfInstances = new Dictionary<string, Func<TransferHandler>>()
            {
                {"1440", () => new NordeaBankTransferHandler()},
                {"1140", () => new MBankTansferHandler()},
                {"2160", () => new ToyotaBankTransferHandler()},
                {"1680", () =>  new PlusBankTransferHandler()},
                {"1050", () => new IngTransferHandler()  }

            };
        }
    }
}