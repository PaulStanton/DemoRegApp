using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity;
using DemoUniversity.Courses;
using DemoUniversity.Users;


namespace DemoRegApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Course testCourse = new Course("course100",new DateTime(),1);
            List<Student> testStudents = new List<Student>();
            Student s = new Student("first", "last", "abcdefg", "a@a.com", 555);
 
            Student paul = new Student("Paul", "a", "pwd", "1@1.com", 1);
            Student mike = new Student("Mike", "a", "pwd", "2@2.com", 2);
            Student stephen = new Student("Stephen", "a", "pwd", "3@3.com", 3);
            Student chris = new Student("Chris", "a", "pwd", "4@4.com", 4);
            Student devonte = new Student("Devonte", "a", "pwd", "5@5.com", 5);
            Student alain = new Student("Alain", "a", "pwd", "6@6.com", 6);
            Student antone = new Student("Antone", "a", "pwd", "7@7.com", 7);
            Student erik = new Student("Erik", "a", "pwd", "8@8.com", 8);
            Student summer = new Student("Summer", "a", "pwd", "9@9.com", 9);
            Student kirk = new Student("Stephen", "1", "pwd", "10@10.com", 10);



            Course dotnet = new Course("dotnet", new DateTime());
            dotnet.AddStudent(paul);
            dotnet.AddStudent(mike);
            dotnet.AddStudent(stephen);
            dotnet.AddStudent(chris);
            dotnet.AddStudent(devonte);
            dotnet.AddStudent(alain);
            dotnet.AddStudent(antone);
            dotnet.AddStudent(erik);
            dotnet.AddStudent(summer);
            dotnet.AddStudent(kirk);

            var studentNamedStephen = dotnet.getStudentByFullName("Stephen1");
            Console.WriteLine(studentNamedStephen.Count());
            Console.ReadLine();
            
        }
    }
}
