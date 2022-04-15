using System;

namespace BuiltInInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { Id = 1 , Age = 29, AverageScore = 75, Name="Onur", Surname="COŞKUN"};
            Student student2 = new Student { Id = 2, Age = 30, AverageScore = 80, Name = "Ümit", Surname = "ŞAHİN" };
            Student student3 = new Student { Id = 2, Age = 26, AverageScore = 85, Name = "Abdullah Halit", Surname = "KORUCUOĞLU" };

            Classroom classroom = new Classroom();
            classroom.AddStudent(student1);
            classroom.AddStudent(student2);
            classroom.AddStudent(student3);

            classroom.Sort();

            //foreach (var item in classroom.GetStudents())
            //{
            //    Console.WriteLine($"{item.Name}, {item.Surname}, {item.Age}, {item.AverageScore}");
            //}

            foreach (Student item in classroom)
            {
                //yield ifadesi sayesinde sınıf içindeki her elemanı tek tek aldık
                Console.WriteLine($"{item.Name}, {item.Surname}, {item.Age}, {item.AverageScore}");
            }
        }
    }
}
