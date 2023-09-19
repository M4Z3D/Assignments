using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Model
{
    internal struct Student
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        // makes the list named _courses
        private List<Course> _courses = new List<Course>();

        // Fill the private properties
        public Student(string FirstName, string LastName, int AgeInYears, int Courses)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _age = AgeInYears;
        }
        // making properties for students and get and set the data
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public List<Course> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

    }
}
