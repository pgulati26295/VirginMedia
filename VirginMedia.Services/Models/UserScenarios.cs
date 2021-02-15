using System;
using System.Collections.Generic;
using System.Text;

namespace VirginMedia.Services.Models
{
   public class UserScenarios
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string UserID { get; set; }
        public List<ScenarioDetail> Scenarios { get; set; }
    }
}
