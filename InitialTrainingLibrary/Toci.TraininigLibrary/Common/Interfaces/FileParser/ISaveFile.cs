﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Common.Interfaces.FileParser
{
    public interface ISaveFile
    {
       bool SaveFile(List<FileEntityBase> entriesList, string fileName);        
    }
}