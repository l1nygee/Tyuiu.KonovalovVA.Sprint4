﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KonovalovVA.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] array)
        {
            int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if(i % 2 != 0) res *= array[i];
            }
            return res;
        }
    }
}
