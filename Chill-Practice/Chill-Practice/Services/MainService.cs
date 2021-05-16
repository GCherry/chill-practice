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
            Problem39_CombinationSum();
        }

        private void Problem39_CombinationSum()
        {
            int[] candidates = { 2, 3, 5 };
            int target = 8;

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
    }
}
