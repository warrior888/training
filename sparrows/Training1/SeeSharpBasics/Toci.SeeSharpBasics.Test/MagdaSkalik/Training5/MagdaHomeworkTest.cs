﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.MagdaSkalik.Training5;

namespace Toci.SeeSharpBasics.Test.MagdaSkalik.Training5
{
    [TestClass]
    public class MagdaHomeworkTest
    {
        [TestMethod]
        public void TestMethod()
        {
            MagdaHomework test = new MagdaHomework();

            test.StringReverse("Magda");
        }
    }
}