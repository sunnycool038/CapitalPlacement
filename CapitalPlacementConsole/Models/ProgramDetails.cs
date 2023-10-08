using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementConsole.Models
{
    public class ProgramDetails
    {
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public string? KeySkillsRequired { get; set; }
        public string? Benefits { get; set; }
        public string? ApplicationCriteria { get; set; }
        public AdditionalInfo? AdditionalProgramInformation { get; set; } = null;
    }

    public class AdditionalInfo
    {
        public string? ProgramType { get; set; }
        public string? ProgramStart { get; set; }
        public string? ApplicationOpen { get; set; }
        public string? ApplicationClose { get; set; }
        public string? Duration { get; set; }
        public Location? ProgramLocation { get; set; }
        public string? MinQualification { get; set; }
        public string? MaxNumberOfApplication { get; set; }
    }

    public class Location
    {
        public string? ProgramLocation { get; set; }
        public bool FullyRemote { get; set; }
    }
}
