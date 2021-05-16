using Chill_Practice.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int[] candidates = { 2, 3, 5 };
            int target = 8;

            var problem39Answer = _leetCodeProblems.Problem39_CombinationSum(candidates, target).FirstOrDefault();
            Console.WriteLine();
            Console.WriteLine($"{problem39Answer}");
        }
    }
}
