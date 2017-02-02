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
            Student s = new Student("Paul", "Stanton", "abcdefg", "pstanton59@gmail.com", 555);
            Console.WriteLine(s.GetInfo());
            for (int i = 0; i < 3; i++)
            {
                testStudents.Add(s);
            }
            testCourse.AddStudents(testStudents);
            for (int i = 0; i < 20; i++)
            {
                testStudents.Add(s);
            }
            Console.WriteLine(testCourse.RosterCount);
            try
            {
                testCourse.AddStudents(testStudents);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
 
            Console.WriteLine(testCourse.RosterCount);
            Console.ReadLine();
            
        }
    }
}
