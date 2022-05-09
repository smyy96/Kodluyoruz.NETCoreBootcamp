using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static double GetSquare(this int value)//this bu metotun extension metot oldugunu vurguluyor. int tipine bir metot eklemiş olduk
        {
            return Math.Pow(value, 2);
        }
        
        public static double GetSquare(this int value, double power)
        {
            return Math.Pow(value, power);
        }


        public static int TotalWorkDays(this DateTime dateTime)
        {
            DateTime startedDate = new DateTime(dateTime.Year, 1, 1);
            DateTime endDate = new DateTime(dateTime.Year, 12, 31);

            int totalWorkDays = 0;
            for (DateTime current = startedDate; current <= endDate; current= current.AddDays(1))
            {
                if (current.DayOfWeek!=DayOfWeek.Sunday && current.DayOfWeek != DayOfWeek.Saturday)
                {
                    totalWorkDays++;
                }
            }

            return totalWorkDays;

        }
        
        
        
        
        public static int TotalWorkDays(this DateTime dateTime, List<DateTime> holidays)
        {
            DateTime startedDate = new DateTime(dateTime.Year, 1, 1);
            DateTime endDate = new DateTime(dateTime.Year, 12, 31);

            int totalWorkDays = 0;
            for (DateTime current = startedDate; current <= endDate; current= current.AddDays(1))
            {
                if (current.DayOfWeek!=DayOfWeek.Sunday && current.DayOfWeek != DayOfWeek.Saturday)
                {
                    totalWorkDays++;
                }

                //foreach (var holiday in holidays)
                //{
                //    if (current.Month == holiday.Month && current.Day == holiday.Day)
                //    {
                //        totalWorkDays++;
                //    }

                //}

                holidays.ForEach(holiday =>
                {
                    if(current.Month == holiday.Month && current.Day == holiday.Day)
                    {
                        totalWorkDays--;
                    }

                });
            }

            return totalWorkDays;

        }

        public static string NextLetter(this Random random)
        {
            int number = new Random().Next(65, 91);
            return ((char)number).ToString();
        }


        public static string NextWord(this Random random, int length = 3)
        {
            string result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                result += random.NextLetter();
            }

            return result;
        }

    }
}
