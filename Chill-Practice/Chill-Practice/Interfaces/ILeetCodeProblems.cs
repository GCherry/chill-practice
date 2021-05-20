using Chill_Practice.DomainObjects;
using System.Collections.Generic;

namespace Chill_Practice.Interfaces
{
    public interface ILeetCodeProblems
    {
        IList<IList<int>> Problem39_CombinationSum(int[] candidates, int target);
        bool Problem100_IsSameTree(TreeNode p, TreeNode q);
    }
}
