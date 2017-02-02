using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity.Users;

namespace DemoUniversity.Courses
{
    interface ICourse
    {

        bool AddStudent(Student student);

        bool RemoveStudent(int id);
        bool RemoveStudent(Student student);
        bool RemoveStudent(string firstname, string lastname);
        
        bool isFull { get;}
        List<Student> GetStudentRoster();
        bool AddStudents(List<Student> roster);

        int RosterCount { get; } 
        string CourseName { get;}


    }
}
