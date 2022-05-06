using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinInterface
{
    public class Student :IComparable //IComparable interface, karşılastırma işlemi yapabilmek için kullanılır sort işleminde
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AverageScore{ get; set; }

        public int CompareTo(object obj) // student içerisndeki ögrencilerin averageScorelarında kıyaslama yapıyor
        {
            var that = (Student)obj;
            if (this.AverageScore > that.AverageScore)
            {
                return 1;
            }
            else if (this.AverageScore < that.AverageScore)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class ClassRoom : IEnumerable // foreach ile dönebilmenin en temel gereksinimi Ienumerable lı implement ederek saglayabiliyoruz
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student) // Ögrenci ekleme
        {
            students.Add(student);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in students)
            {
                yield return item;
            }
        }

        public List<Student> GetStudents() //Ögrencileri almak
        {
            return students;
        }

        public void Sort()// Sıralama
        {
            students.Sort();
        }


    }
}
