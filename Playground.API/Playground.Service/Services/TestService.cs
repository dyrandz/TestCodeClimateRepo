using Playground.Data.DataManagers.Interfaces;
using Playground.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Service.Services
{
    public class TestService : ITestService
    {
        private readonly ITestDataManager _testDataManager;

        public TestService(ITestDataManager testDataManager)
        {
            _testDataManager = testDataManager;
        }

        public async Task<string> Test(string name)
        {
            var result = await _testDataManager.Test();
            return $"Hello, {name} {result}!";
        }

        public async Task<string> Test2(string name)
        {
            var result = await _testDataManager.Test();
            return $"Hello, {name} {result}!";
        }
    }
}
