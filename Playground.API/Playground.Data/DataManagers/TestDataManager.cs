using Playground.Data.DataManagers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Data.DataManagers
{
    public class TestDataManager : ITestDataManager
    {
        public async Task<string> Test()
        {
            return "data";
        }
    }
}
