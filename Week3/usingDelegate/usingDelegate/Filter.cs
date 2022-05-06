﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDelegate
{
    public static class Filters
    {
        //.NET 4.0
        //public delegate bool Criteria(int item);

        /*  delegatelerde
            Void => Action 
            Deger döndüren metotlara da (int, string...) => Func denir.

            Action ve func kullanmaya generic delegate deniliyor.
        
         */
        public static List<int> Filter(List<int> values, Func<int, bool> criteria)//  Func<int, bool> criteria delegate
        {
            List<int> filtered = new List<int>();
            foreach (var item in values)
            {
                if (criteria(item))
                {
                    filtered.Add(item);
                }
            }

            return filtered;
        }

    }
}
