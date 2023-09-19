using Education.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Controller
{
    internal class Controller
    {
        public Controller() 
        
        {


            //making the different courses
            Course course1 = new Course("Math", 1);
            Course course2 = new Course("Danish", 2);
            Course course3 = new Course("OOP", 3);
            Course course4 = new Course("SQL", 4);
            //making a new student
            Student student1 = new Student("Marcus", "Lystrup", 23, 1);
            // adding the course that the student is attending
            student1.Courses.Add(course1);
            student1.Courses.Add(course4);
            student1.Courses.Add(course3);

            // creates a list for the courses
            List<Course> allCourses = new List<Course>()
            {
                course1, course2, course3, course4
            };

            // Prints out all the different courses so you can see all the courses
            Console.WriteLine("All Courses :");
            foreach (Course course in allCourses)
            {
                Console.WriteLine($"{course}");
            }
            // Prints out the information optained on the student
            Console.WriteLine();

            Console.WriteLine($"Student Name: {student1.FirstName} {student1.LastName}");
            Console.WriteLine($"Age: {student1.Age}");


            // writes courses that the students attends by going throught a forloop 
            //it counts the amount of courses the student is assigned and for reach assigned course it writes out the course
            //number that is equal to the i value
            Console.Write("Courses: ");
            for (int i = 0; i < student1.Courses.Count; i++)
            {

                Console.Write(student1.Courses[i].CourseName + " ");
            }

            Console.ReadLine();






        }
    }
}
