using AutoMapper;
using CapitalPlacementConsole.Models;
using CapitalPlacementCRUD.Domain.Models;

namespace CapitalPlacementCRUD.Domain.Profiles
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<ProgramDetails, ProgramDetailsDB>();
        }

    }
}
