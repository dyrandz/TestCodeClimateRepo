using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Data.DataManagers.Interfaces
{
    public interface ITestDataManager
    {
        Task<string> Test();
    }
}
