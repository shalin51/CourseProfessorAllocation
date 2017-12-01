using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDb db = new MyDb();
            Course course = new Course();
            Topic topic = new Topic();
            Expertise expert = new Expertise();
            Professor professor = new Professor();
            CourseTopic courseTopic = new CourseTopic();
           
            List<Professor> professors = db.GetProfessors();
            List<Course> courses = db.GetCourses();
            List<Topic> topics = db.GetTopics();
            List<Expertise> experts = db.GetExpertise();
            List<CourseTopic> courseTopics = db.GetCourseTopics();

            PrintData(courses,topics,professors,experts,courseTopics);            
            GetWeightedTopics(courses, courseTopics);

            Analyser analyser = new Analyser();
                    
            Console.WriteLine("");
            Console.WriteLine("----------- Result --------------");
            Dictionary<int, Dictionary<int, int>> dic = analyser.CreateCourseDictionary();
            List<int> profPerList = new List<int>();
            for (int courseID = 1; courseID < 12; courseID++)
            {
                 profPerList = analyser.GetProfessorForCourse(courseID);
                Console.WriteLine("Course Id :{0} Professor {1} Percentage : {2}", courseID, profPerList[0], profPerList[1]/100);
            }
           Console.ReadLine();
        }

        /// <summary>
        /// Method to get matched porfessors with courses
        /// </summary>
        /// <param name="courses"></param>
        /// <param name="courseTopics"></param>
        private static void GetWeightedTopics(List<Course> courses, List<CourseTopic> courseTopics)
        {
            Dictionary<int, int> weightedTopics = new Dictionary<int, int>();
            for (int index = 1; index <= courses.Count; index++)
            {
                var temp = courseTopics.Where(c => c.CourseId == index);
                foreach (var t in temp)

                {
                    if (!weightedTopics.ContainsKey(t.TopicId))
                    {
                        weightedTopics.Add(t.TopicId, t.Percentage);
                    }
                    else
                    {
                        weightedTopics[t.TopicId] = weightedTopics[t.TopicId] + t.Percentage;
                    }
                }
            }
        }
        /// <summary>
        /// Method to print all related data
        /// </summary>
        /// <param name="courses">List of Courses</param>
        /// <param name="topics">List of Topics</param>
        /// <param name="professors">List of professors</param>
        /// <param name="experts">List of Experttise</param>
        /// <param name="courseTopics">List of Course Topics</param>
        private static void PrintData(List<Course> courses, List<Topic> topics, List<Professor> professors, List<Expertise> experts, List<CourseTopic> courseTopics)
        {
            Console.WriteLine("--------------Courses-----------------");
            foreach (var c in courses)
            {
                Console.WriteLine("{0}-{1}", c.CourseId.ToString(), c.CourseName);
            }
            Console.WriteLine("");
            Console.WriteLine("--------------Topics-----------------");
            foreach (var t in topics)
            {
                Console.WriteLine("{0}-{1}", t.TopicId.ToString(), t.TopicName);
            }
            Console.WriteLine("");
            Console.WriteLine("--------------Professors-----------------");
            foreach (var p in professors)
            {
                Console.WriteLine("{0}-{1}", p.ID.ToString(), p.Name);
            }
            Console.WriteLine("");
            Console.WriteLine("--------------Course with Topics-----------------");
            for (int courseIndex = 1; courseIndex <= courses.Count; courseIndex++)
            {
                Console.Write(courseIndex.ToString() + "- ");
                foreach (var ct in courseTopics.Where((ct) => ct.CourseId == courseIndex))
                {
                    Console.Write("({0},{1}%) ", ct.TopicId, ct.Percentage);
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("--------------Professors with Expertise-----------------");
            for (int professorIndex = 1; professorIndex <= professors.Count; professorIndex++)
            {
                Console.Write(professorIndex.ToString() + "- ");
                foreach (var pe in experts.Where((pe) => pe.ProfessorID == professorIndex))
                {
                    Console.Write("({0}-{1}) ", pe.TopicID, pe.LevelOfExpertise);
                }
                Console.WriteLine();
            }
        }
    }
}
