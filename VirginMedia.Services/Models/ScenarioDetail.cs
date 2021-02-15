using System;
using System.Collections.Generic;
using System.Text;

namespace VirginMedia.Services.Models
{
   public class ScenarioDetail
    {
        public string Name { get; set; }
        public DateTime SampleDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int NumMonths { get; set; }
    }
}
