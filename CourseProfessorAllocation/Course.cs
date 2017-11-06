using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
    public class Course
    {
        public int CourseId { get; set; }
        public String CourseName { get; set; }

        List<Course> courses;

        public List<Course> GetCourses()
        {
            courses = new List<Course>();
            courses.Add(new Course
            {
                CourseId = 1,
                CourseName = "Data Structures"
            });
            courses.Add(new Course
            {
                CourseId = 2,
                CourseName = "Web Development"
            });
            courses.Add(new Course
            {
                CourseId = 3,
                CourseName = "Database"
            });
            courses.Add(new Course
            {
                CourseId = 4,
                CourseName = "Design and Analysis of Algorithms"
            });
            courses.Add(new Course
            {
                CourseId = 5,
                CourseName = "Programming in Python"
            });
            courses.Add(new Course
            {
                CourseId = 6,
                CourseName = "Computer Security-I"
            });
            courses.Add(new Course
            {
                CourseId = 7,
                CourseName = "Computer Security-II"
            });
            courses.Add(new Course
            {
                CourseId = 8,
                CourseName = "Advance Software Engineering"
            });
            courses.Add(new Course
            {
                CourseId = 9,
                CourseName = "Software Architecture and Design"
            });
            courses.Add(new Course
            {
                CourseId = 10,
                CourseName = "Computer Security-I"
            });
            return courses;
        }

    }
}
