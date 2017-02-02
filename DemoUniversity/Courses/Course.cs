using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity.Users;

namespace DemoUniversity.Courses
{
    public class Course : ICourse

    {
        private string courseName= "";
        private string major;
        public bool isClosed;
        private List<Student> studentRoster = new List<Student>();
        private DateTime startTime;
        private int creditHours;

        public Course(string courseName,DateTime startTime, int creditHours=1, string major = "elective")
        {
            this.courseName = courseName;
            this.startTime = startTime;
            this.creditHours = creditHours;
        }

        public delegate bool CloseRegistration(Course thisCourseToClose);

        public CloseRegistration cr=null;

        public bool isFull
        {
            get
            {

                return studentRoster.Count == Global.maxStudents;
            }

        }
        public string CourseName
        {
            get
            {
                return courseName;
            }
        }
        public int RosterCount
        {
            get
            {
                return studentRoster.Count;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool AddStudent(Student student)
        {
            SpaceCheck(studentRoster.Count + 1);
            studentRoster.Add(student);
            if (cr!=null && isFull)
            {
                cr(this);
            }
            return true;
        }

        public bool AddStudents(List<Student> roster)
        {
            SpaceCheck(roster.Count + studentRoster.Count);
            foreach (Student item in roster)
            {
                AddStudent(item);
            }
            return true;
        }

        
        private List<Student> GetStudentRoster()
        {
            return studentRoster;
        }

        public bool RemoveStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStudentByID(int id)
        {

            return studentRoster.Remove(getStudentByID(id));

        }

        public bool RemoveStudent(string firstname, string lastname)
        {
            throw new NotImplementedException();
        }
        private bool SpaceCheck(int countDracula)
        {
            
            if (countDracula > Global.maxStudents)
            {
                throw new Exception(Errors.notEnoughSpace);
            }
            return true; 
        }
        public Student getStudentByID(int id)
        {
            var student = studentRoster.Where(x => x.ID == id).FirstOrDefault();
            return student;
        }
        public IEnumerable<Student> getStudentByFullName(string fn)
        {
            var results = studentRoster.Where(x => x.FullName == fn);
            return results;
        }
        public IEnumerable<Student> getStudentByFullName(string first, string last)
        {
            return (getStudentByFullName(Global.CreateFullName(first,last)));
        }
    }
}
