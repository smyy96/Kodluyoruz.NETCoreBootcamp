using System;

namespace BuiltinInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { Id = 1, Age = 42, AverageScore = 72, Name = "Türkay", LastName = "Ürkmez" };
            Student student2 = new Student { Id = 2, Age = 26, AverageScore = 45, Name = "Mohammed Al", LastName = "Tawil" };
            Student student3 = new Student { Id = 3, Age = 23, AverageScore = 100, Name = "Sümeyye", LastName = "Coşkun" };

            ClassRoom classRoom = new ClassRoom();
            classRoom.AddStudent(student1);
            classRoom.AddStudent(student2);
            classRoom.AddStudent(student3);


            classRoom.Sort();

            foreach (Student item in classRoom)//yield sayesinde sınıf içindeki her bir öğrenciyi tek tek aldım, ClassRoom sınıfına IEnumerable'ı implemente ettikten sonra bu işlemi gercekleştirebiliyoruz.  foreach (var item in classRoom.GetStudents) implemente etmeseydik bu sekilde alabiliyorduk verileri
            {
                Console.WriteLine($" {item.Name} {item.LastName} {item.AverageScore} {item.Age}");
            }
        }
    }
}
