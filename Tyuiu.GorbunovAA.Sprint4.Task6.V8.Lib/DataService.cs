﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GorbunovAA.Sprint4.Task6.V8.Lib
{
    public class DataService : ISprint4Task6V8
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length > 4);
            return mas;
        }
    }
}
