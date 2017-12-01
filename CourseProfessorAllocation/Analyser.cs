using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
    /// <summary>
    /// Analyser class to generate 
    /// </summary>
    public class Analyser
    {
        List<List<int>> arrList = new List<List<int>>();
        List<int> pattern = new List<int> { 6, 9, 12, 18 };
        MyDb db = new MyDb();
        Dictionary<int, Dictionary<int, List<int>>> mainDic = new Dictionary<int, Dictionary<int, List<int>>>();
        Dictionary<int, Dictionary<int, int>> courseTopicDic;
        Dictionary<int, Dictionary<int, int>> pfDict;
        Dictionary<int, int> ignoreList = new Dictionary<int, int>();

        /// <summary>
        /// Constructor method to initialize methods and variables 
        /// </summary>
        public Analyser()
        {
            ListGenerator();
            CreatProfessorHash();
            courseTopicDic = CreateCourseDictionary();
            pfDict = CreateProfessorsDictionary();
        }

        /// <summary>
        /// Method to generate array list
        /// </summary>
        public void ListGenerator()
        {
            arrList.Add(new List<int> { 2, 5, 6, 12, 14, 16, 18, 19, 20 });
            arrList.Add(new List<int> { 1, 2, 3, 5, 8, 9, 12 });
            arrList.Add(new List<int> { 3, 6, 8, 9, 10, 11, 12, 14, 18 });
            arrList.Add(new List<int> { 2, 6, 8, 10, 14, 17, 19 });
            arrList.Add(new List<int> { 4, 5, 6, 9, 16, 17, 18, 19 });
            arrList.Add(new List<int> { 1, 6, 8, 10, 11, 17 });
        }        

        /// <summary>
        /// Method to create professor dictionaries  
        /// </summary>
        public void CreatProfessorHash()
        {
            List<Expertise> expList = db.GetExpertise();
            foreach (Expertise exp in expList)
            {
                if (exp.LevelOfExpertise == 5)
                {
                    MakeMainDictionary(5, exp);
                }
                if (exp.LevelOfExpertise == 4)
                {
                    MakeMainDictionary(4, exp);
                }
                if (exp.LevelOfExpertise == 3)
                {
                    MakeMainDictionary(3, exp);
                }

            }
        }

        /// <summary>
        /// Main Method to create professor dictionaries  
        /// It contains keys for expertise level 3,4 and 5
        /// </summary>
        /// <param name="id">id of the professor</param>
        /// <param name="exp">expertise</param>
        public void MakeMainDictionary(int id, Expertise exp)
        {
            Dictionary<int, List<int>> expDic = new Dictionary<int, List<int>>();
            if (mainDic.ContainsKey(id))
            {
                expDic = mainDic[id];
                mainDic[id] = MakeExpDictionary(expDic, exp);
            }
            else
            {
                expDic = MakeExpDictionary(expDic, exp);
                mainDic.Add(id, expDic);
            }
        }

        /// <summary>
        /// Method to make expertise directory 
        /// </summary>
        /// <param name="expDic">expertise dictionary</param>
        /// <param name="exp">expertise</param>
        /// <returns>expertise dictionary</returns>
        public Dictionary<int, List<int>> MakeExpDictionary(Dictionary<int, List<int>> expDic, Expertise exp)
        {
            List<int> profList = new List<int>();
            if (expDic.ContainsKey(exp.TopicID))
            {
                profList = expDic[exp.TopicID];
                profList.Add(exp.ProfessorID);
                expDic[exp.TopicID] = profList;
            }
            else
            {
                profList.Add(exp.ProfessorID);
                expDic.Add(exp.TopicID, profList);
            }
            return expDic;
        }
        /// <summary>
        /// Method to make course directory 
        /// </summary>
        /// <returns>Course Dictionary</returns>
        public Dictionary<int, Dictionary<int, int>> CreateCourseDictionary()
        {
            Dictionary<int, Dictionary<int, int>> courseDic = new Dictionary<int, Dictionary<int, int>>();
            List<int> ansList = new List<int>();
            List<CourseTopic> ctList = db.GetCourseTopics();
            foreach (CourseTopic ct in ctList)
            {
                Dictionary<int, int> tpDic = new Dictionary<int, int>();
                if (courseDic.ContainsKey(ct.CourseId))
                {
                    tpDic = courseDic[ct.CourseId];
                    tpDic.Add(ct.TopicId, ct.Percentage);
                }
                else
                {
                    tpDic.Add(ct.TopicId, ct.Percentage);
                    courseDic.Add(ct.CourseId, tpDic);
                }
            }

            for (int i = 1; i <= 11; i++)
            {
                Dictionary<int, int> tempDic = courseDic[i];
                courseDic[i] = tempDic.OrderByDescending(d => d.Value).ToDictionary(d => d.Key, d => d.Value);
            }

            return courseDic;
        }
        /// <summary>
        /// Method to make professor directory
        /// </summary>
        /// <returns>rofessor Directory</returns>
        public Dictionary<int, Dictionary<int, int>> CreateProfessorsDictionary()
        {
            Dictionary<int, Dictionary<int, int>> profDic = new Dictionary<int, Dictionary<int, int>>();
            List<int> ansList = new List<int>();
            List<Expertise> peList = db.GetExpertise();
            foreach (Expertise pe in peList)
            {
                Dictionary<int, int> epDic = new Dictionary<int, int>();
                if (profDic.ContainsKey(pe.ProfessorID))
                {
                    epDic = profDic[pe.ProfessorID];
                    epDic.Add(pe.TopicID, pe.LevelOfExpertise);
                }
                else
                {
                    epDic.Add(pe.TopicID, pe.LevelOfExpertise);
                    profDic.Add(pe.ProfessorID, epDic);
                }
            }

            for (int i = 1; i <= 11; i++)
            {
                Dictionary<int, int> tempDic = profDic[i];
                profDic[i] = tempDic.OrderByDescending(d => d.Value).ToDictionary(d => d.Key, d => d.Value);
            }

            return profDic;
        }
        /// <summary>
        /// Method to calculate intersection between two list
        /// </summary>
        /// <param name="sourceList"> source list</param>
        /// <param name="patternList">pattern list</param>
        /// <returns></returns>
        public List<int> GetCommonElements(List<int> sourceList, List<int> patternList)
        {
            List<int> ans = new List<int>();

            int matchPoint = 0;
            int listIndex = 0;
            int patternIndex = 0;
            if (sourceList.Count>0 && patternList.Count>0)
            {
                while (sourceList.Count > listIndex && sourceList[listIndex] <= patternList[patternList.Count - 1] && patternIndex < patternList.Count)
                {
                    if (sourceList[listIndex] == patternList[patternIndex])
                    {
                        ans.Add(sourceList[listIndex]);
                        matchPoint++;
                        listIndex++;
                        patternIndex++;
                    }
                    else if (sourceList[listIndex] < patternList[patternIndex])
                    {
                        listIndex++;
                    }
                    else
                    {
                        patternIndex++;
                    }
                }
            }
           
            return ans;
        }
        /// <summary>
        /// Wrapper main mathod to get professor for course 
        /// </summary>
        /// <param name="courseID">course id</param>
        /// <returns>List to store maximum values </returns>
        public List<int> GetProfessorForCourse(int courseID)
        {
            List<int> max = new List<int>();
            max.Add(0);
            max.Add(0);
            max = GetMax(max, courseID, 5);
            return max;
        }

        /// <summary>
        /// Main mathod to get professor for course
        /// </summary>
        /// <param name="max"></param>
        /// <param name="courseID">course id</param>
        /// <param name="expLevel">expertise level</param>
        /// <returns></returns>
        public List<int> GetMax(List<int> max, int courseID, int expLevel)
        {

            Dictionary<int, int> topics = courseTopicDic[courseID];
            Dictionary<int, List<int>> expDic = new Dictionary<int, List<int>>();
            int index = 0;

            int tempExpLevel = expLevel;
            List<int> lst1;
            List<int> lst2;

            var key1 = topics.Keys.ElementAt(0);
            var key2 = topics.Keys.ElementAt(1);

            expDic = mainDic[tempExpLevel];
            while (!expDic.ContainsKey(key1) && tempExpLevel > 2)
            {

                expDic = mainDic[tempExpLevel];
                --tempExpLevel;
            }
            lst1 = expDic[key1];
           
            expDic = mainDic[expLevel];
            tempExpLevel = expLevel;
            while (!expDic.ContainsKey(key2) && tempExpLevel > 2)
            {

                expDic = mainDic[tempExpLevel];
                --tempExpLevel;
            }
            lst2 = expDic[key2];
            for (int i = 0; i < Math.Max(lst1.Count, lst2.Count); i++)
            {

                if (i < lst1.Count)
                {
                    if (ignoreList.ContainsKey(lst1[i]))
                    {
                        lst1.Remove(lst1[i]);
                    }
                }
                if (i < lst2.Count)
                {
                    if (ignoreList.ContainsKey(lst2[i]))
                    {
                        lst2.Remove(lst2[i]);
                    }
                }
            }
            List<int> common = GetCommonElements(lst1, lst2);

            if (common.Count > 0)
            {
                int commonLength = common.Count;
                for (int i = 0; i < commonLength; i++)
                {
                    int tempMax = CalculatePerc(common[i], topics);
                    if (tempMax > max[1])
                    {
                        max[1] = tempMax;
                        max[0] = common[i];
                    }
                }
            }

            common = lst1.Concat(lst2).ToList();
            index = 0;
            while (index < common.Count)
            {
                int tempMax = 0;
                tempMax = CalculatePerc(common[index], topics);
                if (tempMax > max[1])
                {
                    max[1] = tempMax;
                    max[0] = common[index];
                }
                index++;
            }

            if ((max[1] / 100) < 70 && expLevel > 3)
            {
                max = GetMax(max, courseID, --expLevel);
               
            }
            else
            {
                pfDict.Remove(max[1]);
                if (!ignoreList.ContainsKey(max[0]))
                {
                    ignoreList.Add(max[0], max[0]);
                }
                
            }
            return max;
        }
     
        /// <summary>
        /// Method to calculate match percentage 
        /// </summary>
        /// <param name="profId">professor Id</param>
        /// <param name="topics">opics dictionary</param>
        /// <returns></returns>
        public int CalculatePerc(int profId, Dictionary<int, int> topics)
        {
            int matchPercentage = 0;
            Dictionary<int, int> ptDic;
           
                ptDic = pfDict[profId];
                foreach (var key in topics.Keys)
                {
                    if (ptDic.ContainsKey(key))
                    {
                        int exp = ptDic[key];
                        int per = topics[key];

                        matchPercentage = ((exp * per) / 5 * 100) + matchPercentage;
                    }

               }           
            return matchPercentage;
        }
    }
}