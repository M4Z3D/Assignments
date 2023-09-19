using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Model
{
    public struct Course
    {
        //struct over course's 
        private string _courseName;
        private int _courseId;

        // Filling in the data into the struct
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
        public int CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }
        public Course(string courseName, int courseId)
        {
            _courseName = courseName;
            _courseId = courseId;
        }

        //over riding string and returning the name of the course
        public override string ToString()
        {
            return $"Course: {_courseName}";
        }
    }
}
