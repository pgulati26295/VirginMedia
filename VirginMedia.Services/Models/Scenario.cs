using System;
using System.Collections.Generic;
using System.Text;

namespace VirginMedia.Services.Models
{
    public class Scenario
    {
			public int ScenarioID { get; set; }
			public string Name { get; set; }
			public string Surname { get; set; }
			public string Forename { get; set; }
			public string UserID { get; set; }
			public DateTime SampleDate { get; set; }
			public DateTime CreationDate { get; set; }
			public int NumMonths { get; set; }
			public int MarketID { get; set; }
			public int NetworkLayerID { get; set; }

	}
}
