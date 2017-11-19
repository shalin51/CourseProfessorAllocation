using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
    public class MyDb
    {
        Course course = new Course();
        Topic topic = new Topic();
        Expertise expertise = new Expertise();
        Professor professor = new Professor();
        CourseTopic courseTopic = new CourseTopic();


        List<Course> courses;
        List<Expertise> expert;
        List<Professor> professors;
        List<CourseTopic> courseTopics;
        List<Topic> topics;

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
                CourseName = "Advance Operating System"
            });
            courses.Add(new Course
            {
                CourseId = 11,
                CourseName = "Internet of Things"
            });
            return courses;
        }
        public List<Expertise> GetExpertise()
        {
            expert = new List<Expertise>();

            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 15,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 16,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 10,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 2,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 3,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 19,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 20,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 18,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 4,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 7,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 1,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 2,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 10,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 12,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 19,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 6,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 8,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 11,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 15,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 4,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 13,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 14,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 16,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 2,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 19,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 20,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 15,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 9,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 10,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 20,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 19,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 16,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 5,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 9,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 11,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 3,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 4,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 17,
                LevelOfExpertise = 5
            });
            
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 2,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 1,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 19,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 20,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 18,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 1,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 2,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 12,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 9,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 6,
                LevelOfExpertise = 1
            });          
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 3,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 6,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 7,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 8,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 17,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 13,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 14,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 12,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 9,
                LevelOfExpertise = 3
            });            
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 2,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 6,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 7,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 8,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 12,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 10,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 9,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 4,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 2,
                LevelOfExpertise = 2
            });            
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 5,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 1,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 2,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 5,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 12,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 10,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 19,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 3,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 7,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 9,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 11,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 6,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 20,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 3,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 4,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 12,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 11,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 5,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 7,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 8,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 17,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 13,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 19,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 20,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 15,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 9,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 10,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 11,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 16,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 13,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 8,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 7,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 1,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 20,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 19,
                LevelOfExpertise = 2
            });
           
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 12,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 9,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 17,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 16,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 14,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 13,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 1,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 2,
                LevelOfExpertise = 1
            });
            return expert;
        }
        public List<Professor> GetProfessors()
        {
            professors = new List<Professor>();

            professors.Add(new Professor
            {
                ID = 1,
                Name = "Dr. Lee"
            });
            professors.Add(new Professor
            {
                ID = 2,
                Name = "Dr. Song"
            });
            professors.Add(new Professor
            {
                ID = 3,
                Name = "Dr. James"
            });
            professors.Add(new Professor
            {
                ID = 4,
                Name = "Dr. Kaley"
            });
            professors.Add(new Professor
            {
                ID = 5,
                Name = "Dr. Lay"
            });
            professors.Add(new Professor
            {
                ID = 6,
                Name = "Dr. Zheng"
            });
            professors.Add(new Professor
            {
                ID = 7,
                Name = "Dr. Harn"
            });
            professors.Add(new Professor
            {
                ID = 8,
                Name = "Dr. Khatib"
            });
            professors.Add(new Professor
            {
                ID = 9,
                Name = "Dr. Rao"
            });
            professors.Add(new Professor
            {
                ID = 10,
                Name = "Dr. Patel"
            });
            professors.Add(new Professor
            {
                ID = 11,
                Name = "Dr. Shukla"
            });
            return professors;
        }
        public List<CourseTopic> GetCourseTopics()
        {
            courseTopics = new List<CourseTopic>();
            courseTopics.Add(new CourseTopic
            {
                CourseId = 1,
                TopicId = 15,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 1,
                TopicId = 16,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 1,
                TopicId = 10,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 1,
                TopicId = 2,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 1,
                TopicId = 3,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 2,
                TopicId = 1,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 2,
                TopicId = 2,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 2,
                TopicId = 10,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 2,
                TopicId = 12,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 2,
                TopicId = 19,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 3,
                TopicId = 13,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 3,
                TopicId = 14,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 3,
                TopicId = 16,
                Percentage = 40
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 4,
                TopicId = 2,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 4,
                TopicId = 3,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 4,
                TopicId = 4,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 4,
                TopicId = 17,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 5,
                TopicId = 19,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 5,
                TopicId = 20,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 5,
                TopicId = 18,
                Percentage = 50
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 6,
                TopicId = 3,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 6,
                TopicId = 6,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 6,
                TopicId = 7,
                Percentage = 60
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 6,
                TopicId = 8,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 7,
                TopicId = 6,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 7,
                TopicId = 7,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 7,
                TopicId = 8,
                Percentage = 50
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 8,
                TopicId = 1,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 8,
                TopicId = 2,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 8,
                TopicId = 5,
                Percentage = 15
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 8,
                TopicId = 12,
                Percentage = 30
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 8,
                TopicId = 10,
                Percentage = 20
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 8,
                TopicId = 19,
                Percentage = 5
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 9,
                TopicId = 3,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 9,
                TopicId = 4,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 9,
                TopicId = 12,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 9,
                TopicId = 11,
                Percentage = 70
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 10,
                TopicId = 20,
                Percentage = 25
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 10,
                TopicId = 15,
                Percentage = 15
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 10,
                TopicId = 9,
                Percentage = 50
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 10,
                TopicId = 10,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 11,
                TopicId = 20,
                Percentage = 10
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 11,
                TopicId = 19,
                Percentage = 5
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 11,
                TopicId = 16,
                Percentage = 14
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 11,
                TopicId = 12,
                Percentage = 31
            });
            courseTopics.Add(new CourseTopic
            {
                CourseId = 11,
                TopicId = 9,
                Percentage = 40
            });
            return courseTopics;
        }
        public List<Topic> GetTopics()
        {
            topics = new List<Topic>();
            topics.Add(new Topic
            {
                TopicId = 1,
                TopicName = "HTML",
            });
           
            topics.Add(new Topic
            {
                TopicId = 2,
                TopicName = "Programing Languages",
            });
            topics.Add(new Topic
            {
                TopicId = 3,
                TopicName = "Statistics",
            });
            topics.Add(new Topic
            {
                TopicId = 4,
                TopicName = "Algorithms",
            });
            topics.Add(new Topic
            {
                TopicId = 5,
                TopicName = "Machine Learning",
            });
            topics.Add(new Topic
            {
                TopicId = 6,
                TopicName = "Interpolation",
            });
            topics.Add(new Topic
            {
                TopicId = 7,
                TopicName = "Security",
            });
            topics.Add(new Topic
            {
                TopicId = 8,
                TopicName = "Computer Security",
            });
            topics.Add(new Topic
            {
                TopicId = 9,
                TopicName = "Hardware",
            });
            topics.Add(new Topic
            {
                TopicId = 10,
                TopicName = "Software",
            });
            topics.Add(new Topic
            {
                TopicId = 11,
                TopicName = "Software Architecture",
            });
            topics.Add(new Topic
            {
                TopicId = 12,
                TopicName = "Cloud computing ",
            });
            topics.Add(new Topic
            {
                TopicId = 13,
                TopicName = "Hadoop",
            });
            topics.Add(new Topic
            {
                TopicId = 14,
                TopicName = "Spark",
            });
            topics.Add(new Topic
            {
                TopicId = 15,
                TopicName = "Logical Gates",
            });
            topics.Add(new Topic
            {
                TopicId = 16,
                TopicName = "Data design",
            });
            topics.Add(new Topic
            {
                TopicId = 17,
                TopicName = "Dynamic Programing",
            });
            topics.Add(new Topic
            {
                TopicId = 18,
                TopicName = "Python",
            });
            topics.Add(new Topic
            {
                TopicId = 19,
                TopicName = "IDE",
            });
            topics.Add(new Topic
            {
                TopicId = 20,
                TopicName = "CLI",
            });
            return topics;
        }
    }
}

