using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
    public class Topic
    {
        public int TopicId { get; set; }
        public String TopicName { get; set; }

        List<Topic> topics;

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
                TopicId =16,
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
