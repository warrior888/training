﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;


namespace Toci.TrainingLibrary.Test.Developers.Dysq
{
    [TestClass]
    public class DysqFileParserTest
    {
        [TestMethod]
        public void TestDysqFileParser()
        {
        
            DysqFileDetailParser parser = new DysqFileDetailParser();
           

          //string filePath = @"E:\Szkolenia\InitialTrainingLibrary\Toci.TraininigLibrary\data\transfer_2015-03-02_987654321_dysq.txt";
          string filePath = @"..\..\..\Toci.TraininigLibrary\data\transfer_2015-03-02_987654321_dysq.txt";
          //string filePath = @"F:\self\projects\training\InitialTrainingLibrary\Toci.TraininigLibrary\data\transfer_2015-03-02_987654321_dysq.txt";

            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {   while(!reader.EndOfStream)
                lines.Add(reader.ReadLine());

            }

           var test = parser.ReadEntry(lines[0]);

            Assert.AreEqual(test.Name, "Mateusz");
        }
    }
}
