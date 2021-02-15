using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VirginMedia.Data.Interfaces;
using VirginMedia.Services.Interfaces;
using Data = VirginMedia.Data.Model;
using System.Linq;
using Model = VirginMedia.Services.Models;
using VirginMedia.Services.Models;
using System.Threading.Tasks;

namespace VirginMedia.Services.Implementations
{
  public class ScenarioData : IScenario
    {
        private readonly IFile _file;
        private readonly IMapper _mapper;
        public ScenarioData(IFile file, IMapper mapper)
        {
            _file = file;
            _mapper = mapper;
        }

        public async Task<List<Model.Scenario>> GetScenarioData()
        {
           var scenarios = await _file.LoadObjectFromFile();
           var scenarioList = _mapper.Map<List<Model.Scenario>>(scenarios.Scenario);
           return scenarioList;
          
        }

        public async Task<List<UserScenarios>> GetSummaryPerUser()
        {
            List<UserScenarios> userScenarioList = new List<UserScenarios>();
            var scenarios = await GetScenarioData();
            var userScenarios = from sc in scenarios
                                group sc by new { sc.UserID, sc.Forename, sc.Surname } into userGroup
                                select new 
                                {
                                    Userid = userGroup.Key.UserID,
                                    Forename = userGroup.Key.Forename,
                                    Surname = userGroup.Key.Surname,
                                    Scenarios =
                                    userGroup.ToList().GroupBy(x => new
                                    {
                                        x.Name,
                                        x.SampleDate,
                                        x.CreationDate,
                                        x.NumMonths
                                    })
                                    .Select(x => new ScenarioDetail
                                    {
                                        Name = x.Key.Name,
                                        SampleDate = x.Key.SampleDate,
                                        CreationDate = x.Key.CreationDate,
                                        NumMonths = x.Key.NumMonths
                                      
                                    })
                                };


            foreach (var group in userScenarios)
            {
                userScenarioList.Add(
                    new UserScenarios
                    {
                        UserID = group.Userid,
                        Forename = group.Forename,
                        Surname = group.Surname,
                        Scenarios = group.Scenarios.ToList()
                    }); 

            }
            return userScenarioList;
        }

    }
}
