using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VirginMedia.Services.Models;
using Model = VirginMedia.Services.Models;

namespace VirginMedia.Services.Interfaces
{
   public interface IScenario
    {
       Task<List<Model.Scenario>> GetScenarioData();

       Task<List<UserScenarios>> GetSummaryPerUser();
    }
}
