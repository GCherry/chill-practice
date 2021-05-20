using Chill_Practice.DomainObjects;
using Chill_Practice.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Chill_Practice.Services
{
    public class LeetCodeProblems : ILeetCodeProblems
    {
        public bool Problem100_IsSameTree(TreeNode p, TreeNode q)
        {
            if (Equals(p, null) || Equals(q, null))
            {
                return Equals(q, p);
            }

            return Equals(p.val, q.val) && Problem100_IsSameTree(p.left, q.left) && Problem100_IsSameTree(p.right, q.right);
        }

        public IList<IList<int>> Problem39_CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> comb = new List<int>();

            CombinationSum(candidates, target, 0, 0, comb, result);
            return result;
        }

        private void CombinationSum(int[] candidate, int target, int sum, int arrayLocation, List<int> combo, List<IList<int>> result)
        {
            // Check if the current set of possibilities is greater than the target passed in
            if (sum > target)
            {
                return;
            }

            // If the current combination's sum equals the target add it to the result set and continue looking for more combinations
            if (sum == target)
            {
                result.Add(combo.ToList());
                return;
            }

            while (arrayLocation < candidate.Length)
            {
                // ADd the current candidate to the current combo to check if it will add up to the target
                sum += candidate[arrayLocation];
                combo.Add(candidate[arrayLocation]);

                // Create
                CombinationSum(candidate, target, sum, arrayLocation, combo, result);

                // After going through the possibilities lets backtrack and see if we can make more matching combinations from where we currently are
                sum -= candidate[arrayLocation];
                combo.RemoveAt(combo.Count - 1);
                arrayLocation++;
            }
        }
    }
}


