﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Startup.Test
{
    public class PkoBp : Bank
    {
        public PkoBp(string name, int id)
        {
            this.BankName = name;
            this.BankId = id;
        }

    }
}
