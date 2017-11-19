using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
    public class Analyser
    {

        List<List<int>> arrList = new List<List<int>>();
        List<int> pattern = new List<int> { 6, 9, 12, 18 };
        MyDb db = new MyDb();
        Dictionary<int, Dictionary<int, List<int>>> mainDic = new Dictionary<int, Dictionary<int, List<int>>>();
        Dictionary<int, Dictionary<int, int>> courseTopicDic;
        public Analyser()
        {
            ListGenerator();
            CreatProfessorHash();
            courseTopicDic = CreateCourseDictionary();
        }
        public void ListGenerator()
        {
            arrList.Add(new List<int> { 2, 5, 6, 12, 14, 16, 18, 19, 20 });
            arrList.Add(new List<int> { 1, 2, 3, 5, 8, 9, 12 });
            arrList.Add(new List<int> { 3, 6, 8, 9, 10, 11, 12, 14, 18 });
            arrList.Add(new List<int> { 2, 6, 8, 10, 14, 17, 19 });
            arrList.Add(new List<int> { 4, 5, 6, 9, 16, 17, 18, 19 });
            arrList.Add(new List<int> { 1, 6, 8, 10, 11, 17 });
        }
        public List<List<int>> GetMatchedList()
        {
            List<List<int>> ans = new List<List<int>>();
            Dictionary<int, int> indexDic = new Dictionary<int, int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();


            for (int i = 0; i < arrList.Count; i++)
            {
                if (indexDic.ContainsKey(GetMatchedList(arrList[i])))
                {
                    indexDic[GetMatchedList(arrList[i])] = i;
                }
                else
                {
                    indexDic.Add(GetMatchedList(arrList[i]), i);
                }

            }
            return ans;
        }
        private int GetMatchedList(List<int> list)
        {
            int matchPoint = 0;
            int listIndex = 0;
            int patternIndex = 0;

            while (list.Count > listIndex && list[listIndex] <= pattern[pattern.Count - 1] && patternIndex < pattern.Count)
            {
                if (list[listIndex] == pattern[patternIndex])
                {
                    matchPoint++;
                    listIndex++;
                    patternIndex++;
                }
                else if (list[listIndex] < pattern[patternIndex])
                {
                    listIndex++;
                }
                else
                {
                    patternIndex++;
                }

            }

            return matchPoint;
        }
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
        public List<int> GetCommonElements(List<int> sourceList, List<int> patternList)
        {
            List<int> ans = new List<int>();

            int matchPoint = 0;
            int listIndex = 0;
            int patternIndex = 0;
            while (sourceList.Count > listIndex && sourceList[listIndex] <= patternList[patternList.Count - 1] && patternIndex < patternList.Count)
            {
                if (sourceList[listIndex] == pattern[patternIndex])
                {
                    matchPoint++;
                    listIndex++;
                    patternIndex++;
                    ans.Add(sourceList[listIndex]);
                }
                else if (sourceList[listIndex] < pattern[patternIndex])
                {
                    listIndex++;
                }
                else
                {
                    patternIndex++;
                }
            }
            return ans;
        }
        public int GetProfessorForCourse(int courseID)
        {
            int max = 0;

            GetMax(courseID, 5);


            return max;
        }

        public int GetMax(int courseID, int expLevel)
        {
            int max = 0;
            Dictionary<int, int> topics = courseTopicDic[courseID];
            Dictionary<int, List<int>> expDic = new Dictionary<int, List<int>>();
            int index = 0;
            int tempExpLevel = expLevel;
            List<int> lst1;
            List<int> lst2;

            var key1 = topics.Keys.ElementAt(0);
            var key2 = topics.Keys.ElementAt(1);

            expDic = mainDic[tempExpLevel];
            while (!expDic.ContainsKey(key1) && tempExpLevel > 0)
            {
                --tempExpLevel;
                expDic = mainDic[tempExpLevel];
            }
            lst1 = expDic[key1];

            expDic = mainDic[expLevel];
            tempExpLevel = expLevel;
            while (!expDic.ContainsKey(key2) && tempExpLevel > 0)
            {
                --tempExpLevel;
                expDic = mainDic[tempExpLevel];
            }
            lst2 = expDic[key2];

            List<int> common = GetCommonElements(lst1, lst2);

            if (common.Count > 0)
            {
                int commonLength = common.Count;
                for (int i = 0; i < commonLength; i++)
                {
                    int tempMax = CalculatePerc(common[i], topics);
                    if (tempMax > max)
                    {
                        max = tempMax;
                    }
                }
            }

            common = lst1.Concat(lst2).ToList();
            index = common.Count-1;
            while ((max / 100) < 70 && index>=0)
            {
                int tempMax = 0;
                tempMax = CalculatePerc(common[index], topics);
                if (tempMax > max)
                {
                    max = tempMax;
                }
                index--;
                
            }

            if ((max / 100) < 70)
            {
                GetMax(courseID, expLevel--);
            }
            return max/100;
        }

        public int CalculatePerc(int profId, Dictionary<int, int> topics)
        {
            int matchPercentage = 0;


            Dictionary<int, Dictionary<int, int>> pfDict = CreateProfessorsDictionary();
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