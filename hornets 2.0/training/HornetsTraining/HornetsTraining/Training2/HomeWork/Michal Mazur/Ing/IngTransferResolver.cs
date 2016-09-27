﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using HornetsTraining.Training1.Generics.Factory;
using HornetsTraining.Training2.HomeWork.Ing;
using Toci.HornetsTraining.Training1.Generics.Factory;

namespace HornetsTraining.Training2.HomeWork.MichalMazur
{
    public class IngTransferResolver : TransferResolver
    {
        private DelegateFactoryBase<TransferHandler> factory; 
        public IngTransferResolver()
        {
            factory = new IngTransferHandlerFactory();

        }
        public override void DoTransfer(Transfer transfer)
        {
            string DestinationBankID = transfer.DestinationBankAccount.Substring(2, 4);
            string SourceBankID = transfer.SourceBankAccount.Substring(2, 4);
             
             factory.GetInstance(SourceBankID).DoOutTransfer(transfer);
             factory.GetInstance(DestinationBankID).DoInTransfer(transfer);

        
        }
        
    }
}

