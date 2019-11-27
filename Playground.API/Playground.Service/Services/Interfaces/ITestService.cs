using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Service.Services.Interfaces
{
    public interface ITestService
    {
        Task<string> Test(string name);
    }
}
