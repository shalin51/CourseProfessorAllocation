using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
    public class Professor
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public List<Professor> professors;

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
    }
}
