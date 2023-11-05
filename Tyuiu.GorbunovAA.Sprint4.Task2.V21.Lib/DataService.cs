﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GorbunovAA.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task1V21
    {
        public int Calculate(int[] array)
        {
            int count = 1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                    count *= array[i];
            return count;
        }
    }
}
