using Chill_Practice.DomainObjects;
using Chill_Practice.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace Chill_Practice.Services
{
    public class MainService : IMainService
    {
        private readonly ILogger<MainService> _log;
        private readonly IConfiguration _config;
        private readonly ILeetCodeProblems _leetCodeProblems;

        public MainService(ILogger<MainService> log, IConfiguration config, ILeetCodeProblems leetCodeProblems)
        {
            _log = log;
            _config = config;
            _leetCodeProblems = leetCodeProblems;
        }

        public void Run()
        {
            //Problem39_CombinationSum();
            Problem100_IsSameTree();
        }

        private void Problem39_CombinationSum()
        {
            int[] candidates = { 2, 7, 6, 3, 5, 1 };
            int target = 9;

            var problem39Answer = _leetCodeProblems.Problem39_CombinationSum(candidates, target);
            Console.WriteLine();

            _log.LogInformation(".........Starting - Problem 39 Combination Sum");
            Console.WriteLine();

            foreach (var item in problem39Answer)
            {
                foreach (var result in item)
                {
                    Console.Write($"{result} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            _log.LogInformation(".........Finished - Problem 39 Combination Sum");
        }

        private void Problem100_IsSameTree()
        {
            var leftNode = new TreeNode()
            {
                val = 1,
                left = new TreeNode() { val = 3},
                right = new TreeNode() { val = 3 }
            };

            var rightNode = new TreeNode()
            {
                val = 1,
                left = new TreeNode() { val = 3 },
                right = new TreeNode() { val = 3 }
            };

            Console.WriteLine();

            _log.LogInformation(".........Starting - Problem 100 Is Same Tree");
            Console.WriteLine();

            var problem100Answer = _leetCodeProblems.Problem100_IsSameTree(leftNode, rightNode);
            Console.WriteLine($"{problem100Answer}");

            Console.WriteLine();
            _log.LogInformation(".........Finished - Problem 100 Is Same Tree");
        }
    }
}
