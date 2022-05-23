using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class CourseSchedule
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
            for (int i = 0; i < prerequisites.Length; i++)
            {
                if (adj.ContainsKey(prerequisites[i][0]))
                    adj[prerequisites[i][0]].Add(prerequisites[i][1]);
                else
                    adj.Add(prerequisites[i][0], new List<int> { prerequisites[i][1] });
            }

            for (int i = 0; i < numCourses; i++)
            {
                bool[] isDone = new bool[numCourses];
                if (!IsDFSExplored(i, adj, isDone))
                    return false;
            }
            return true;
        }

        public static bool IsDFSExplored(int course, Dictionary<int, List<int>> adj, bool[] isDone)
        {
            if (isDone[course])
                return false;
            isDone[course] = true;
            if (!adj.ContainsKey(course))
                return true;
            foreach (int dCourse in adj[course])
            {
                if (!IsDFSExplored(dCourse, adj, isDone))
                    return false;
            }
            return true;
        }
    }
}
