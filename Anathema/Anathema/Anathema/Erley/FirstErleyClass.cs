﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Erley
{
    class FirstErleyClass : Dictionary<FirstErleyClass, FirstErleyClass>
    {
        public void dupa()
        {
            Dictionary<Func<FirstErleyClass, bool>, List<Func<Dictionary<FirstErleyClass, ConcurrentBag<FirstErleyClass>>, List<FirstErleyClass>>>> dafaq = new Dictionary<Func<FirstErleyClass, bool>, List<Func<Dictionary<FirstErleyClass, ConcurrentBag<FirstErleyClass>>, List<FirstErleyClass>>>>();

            //dafaq.Add(?, ?);
        }
    }
}
