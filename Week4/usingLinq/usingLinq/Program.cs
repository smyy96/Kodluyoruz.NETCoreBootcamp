using System;
using System.Collections.Generic;
using System.Linq;

namespace usingLinq
{
    class Program
    {
        private static List<Student> students;
        static void Main(string[] args)
        {
            //Language INtegrated Query. (veri tabanındaki bir tabloymuş gibi sorgu çekebiliyoruz.)
            students = new List<Student>
           {
                new Student { Id =1, Name="Sümeyye", LastName="Coşkun", Age=23, AverageScore=99.9, Info="lying about her age."  },
                new Student { Id =2, Name="Türkay", LastName="Ürkmez", Age=42, AverageScore=85, Info="He was a meh student!"  },
                new Student { Id =3, Name="Nur", LastName="Bil", Age=29, AverageScore=69.4  },
                new Student { Id =4, Name="Umut", LastName="Oku", Age=29, AverageScore=54  }
            };

            basicLinq();
            getAverageScore();
        }

        private static void getAverageScore()
        {
            var average = students.Average(x => x.AverageScore);
            Console.WriteLine($"Ortalama: {average}");
        }

        private static void basicLinq()
        {
            var scorebigThan70 = from student in students 
                                 where student.AverageScore >= 70 
                                 select student;

            
            var alternativeBigThanFive = students.Where(c => c.AverageScore >= 70)
                                                    .OrderBy(x=>x.LastName)
                                                    .ToList();
            
            
            alternativeBigThanFive.ForEach(stu => Console.WriteLine($"{stu.Name} {stu.LastName}"));


            //Extension metot= where, orderby, tolist ...
        }
    }
}
