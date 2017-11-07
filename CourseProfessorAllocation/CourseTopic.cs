using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
    public class CourseTopic
    {
        public int CourseId { get; set; }
        public int TopicId { get; set; }
        public int Percentage { get; set; }
        List<CourseTopic> courseTopics;

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
    }
}
