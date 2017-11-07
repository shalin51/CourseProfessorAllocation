using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
   public class Expertise
    {
        public int TopicID { get; set; }
        public int ProfessorID { get; set; }
        public int LevelOfExpertise { get; set; }

        List<Expertise> expert;

        public List<Expertise> GetExpertise()
        {
            expert = new List<Expertise>();
            
            expert.Add( new Expertise
                {
                    ProfessorID=1,
                    TopicID=15,
                    LevelOfExpertise=4
                });
            expert.Add(new Expertise
                {
                    ProfessorID = 1,
                    TopicID = 16,
                    LevelOfExpertise = 4
                });
            expert.Add(new Expertise
                {
                    ProfessorID = 1,
                    TopicID = 10,
                    LevelOfExpertise = 2
                });
            expert.Add(new Expertise
                {
                    ProfessorID = 1,
                    TopicID = 2,
                    LevelOfExpertise = 4
                });
            expert.Add(new Expertise
                {
                    ProfessorID = 1,
                    TopicID = 3,
                    LevelOfExpertise = 5
                });
            expert.Add(new Expertise
            {
                ProfessorID = 1,
                TopicID = 19,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
                {
                    ProfessorID = 1,
                    TopicID = 20,
                    LevelOfExpertise = 2
                });
            expert.Add(new Expertise
                {
                    ProfessorID = 1,
                    TopicID = 18,
                    LevelOfExpertise = 3
                });
            expert.Add(new Expertise
                {
                    ProfessorID = 1,
                    TopicID = 4,
                    LevelOfExpertise = 2
                });
            expert.Add(new Expertise
                {
                    ProfessorID = 1,
                    TopicID = 7,
                    LevelOfExpertise = 2
                });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 1,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 2,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 10,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 12,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 19,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 6,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 8,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 11,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 15,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 2,
                TopicID = 4,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 13,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 14,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 16,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 2,
                LevelOfExpertise = 2
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
                TopicID = 20,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 15,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 9,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 3,
                TopicID = 10,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 20,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 19,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 16,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 12,
                TopicID = 5,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 9,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 11,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 8,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 15,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 17,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 4,
                TopicID = 5,
                LevelOfExpertise = 3
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
                TopicID = 1,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 19,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 20,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 18,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 1,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 2,
                LevelOfExpertise = 3
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
                TopicID = 6,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 5,
                TopicID = 2,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 3,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 6,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 7,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 8,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 17,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID = 13,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 6,
                TopicID =14,
                LevelOfExpertise = 1
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
                ProfessorID = 6,
                TopicID = 2,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 6,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 7,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 8,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 12,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 10,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 9,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 4,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 2,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 1,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 7,
                TopicID = 5,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 1,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 2,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 5,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 12,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 10,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 19,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 3,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 7,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 9,
                LevelOfExpertise = 1
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
                TopicID = 6,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 8,
                TopicID = 20,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 3,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 4,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 12,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 11,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 5,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 7,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 8,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 17,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 13,
                LevelOfExpertise = 4
            });
            expert.Add(new Expertise
            {
                ProfessorID = 9,
                TopicID = 19,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 20,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 15,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 9,
                LevelOfExpertise = 5
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 10,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 11,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 16,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 13,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 10,
                TopicID = 8,
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
                TopicID = 1,
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
                TopicID = 19,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 16,
                LevelOfExpertise = 3
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 12,
                LevelOfExpertise = 5
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
                TopicID = 17,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 16,
                LevelOfExpertise = 2
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 14,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 13,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 1,
                LevelOfExpertise = 1
            });
            expert.Add(new Expertise
            {
                ProfessorID = 11,
                TopicID = 2,
                LevelOfExpertise = 1
            });
            return expert;
        }
    }
}
