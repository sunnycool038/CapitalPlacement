using CapitalPlacementCRUD.Domain.Models;

namespace CapitalPlacementCRUD.Domain.Interface
{
    public interface ITab1Service
    {
        Task<bool> InsertDetails(ProgramDetailsDB detailsDB);
    }
}
