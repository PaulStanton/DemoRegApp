using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity.Courses;

namespace DemoUniversity.Users
{
    public class Student : User
    {
        private string major;
        private bool isFullTime;
        //   List<Course> classes = new List<Course>();
        Dictionary<string, Course> classes = new Dictionary<string, Course>();
        // enum year

        public Student(string firstname, string lastname, string password, string email, int id, string major = "undecided") : base(firstname, lastname, password, email, id)
        {
            this.major = major;
            isFullTime = false;
            //initialize array of courses
        }

        public override string GetInfo()
        {
            StringBuilder info = new StringBuilder(base.ToString());
            info.Append($"\n{major}");
            info.Append($"\nfulltime: {isFullTime}");
            if(classes.Count ==0)
            {
                info.Append($"\nnot registered for classes");
            }else
            foreach (KeyValuePair<String,Course> item in classes)
            {
                    info.Append($"\n{item.Value.CourseName}");
                }
            return info.ToString();
        }
    }
}
