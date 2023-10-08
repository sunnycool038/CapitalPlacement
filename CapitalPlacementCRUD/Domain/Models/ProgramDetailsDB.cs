using CapitalPlacementConsole.Models;

namespace CapitalPlacementCRUD.Domain.Models
{
    public class ProgramDetailsDB
    {
        public string? id { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public string? KeySkillsRequired { get; set; }
        public string? Benefits { get; set; }
        public string? ApplicationCriteria { get; set; }
        public AdditionalInfo? AdditionalProgramInformation { get; set; } = null;
    }
}
