using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            Console.WriteLine(x.GetSquare());



            List<DateTime> holidays = new List<DateTime>
            {
                new DateTime(2022,1,1),
                new DateTime(2022,4,23),
                new DateTime(2022,5,2),
                new DateTime(2022,5,3),
                new DateTime(2022,5,4),
                new DateTime(2022,5,19)
            };


            // bir yıl içinde toplam çalışılan ögün sayısı
            Console.WriteLine(DateTime.Now.TotalWorkDays(holidays));




            Random random = new Random();
            Console.WriteLine(random.NextLetter());
            Console.WriteLine(random.NextWord(5));
;

        }
    }
}
