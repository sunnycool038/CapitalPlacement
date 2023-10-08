using CapitalPlacementCRUD.Domain.Models;

namespace CapitalPlacementCRUD.Domain.Interface
{
    public interface IProgramDetailsRecord
    {
        Task<bool> Create(ProgramDetailsDB newBook);
    }
}
