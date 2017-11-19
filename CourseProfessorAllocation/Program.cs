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

            //PrintData(courses,topics,professors,experts,courseTopics);            
            GetWeightedTopics(courses, courseTopics);

            //BST bst = new BST();
            //bst.SortBST();

            Analyser analyser = new Analyser();
            //analyser.GetMatchedList();

            //analyser.CreatProfessorHash();

            //Console.WriteLine("----------------------------------");

            //Dictionary<int, Dictionary<int, int>> courseDic= analyser.CreateCourseDictionary();

            //for (int index = 1; index <= 11; index++)
            //{
            //    Console.WriteLine("----------Course {0}---------",index);
            //    foreach (var key in courseDic[index].Keys)
            //    {
            //        Console.WriteLine("Topic Id :{0} Percentage : {1}",key,courseDic[index][key]);
            //    }
            //}

            Dictionary<int, Dictionary<int, int>> dic = analyser.CreateCourseDictionary();
            int courseID = 1;

            analyser.GetProfessorForCourse(courseID);

            Console.ReadLine();
        }

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
        private static void PrintData(List<Course> courses, List<Topic> topics, List<Professor> professors, List<Expertise> experts, List<CourseTopic> courseTopics)
        {
            Console.WriteLine("--------------Courses-----------------");
            foreach (var c in courses)
            {
                Console.WriteLine("{0}-{1}", c.CourseId.ToString(), c.CourseName);
            }
            Console.WriteLine("--------------Topics-----------------");
            foreach (var t in topics)
            {
                Console.WriteLine("{0}-{1}", t.TopicId.ToString(), t.TopicName);
            }
            Console.WriteLine("--------------Professors-----------------");
            foreach (var p in professors)
            {
                Console.WriteLine("{0}-{1}", p.ID.ToString(), p.Name);
            }
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
