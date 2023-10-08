using CapitalPlacementCRUD.Domain.Interface;
using CapitalPlacementCRUD.Domain.Models;

namespace CapitalPlacementCRUD.Services
{
    public class Tab1Service : ITab1Service
    {
        private readonly IProgramDetailsRecord _db;
        public Tab1Service(IProgramDetailsRecord db)
        {
            _db = db;
        }

        public async Task<bool> InsertDetails(ProgramDetailsDB detailsDB)
        {
            try
            {
                var res = await _db.Create(detailsDB);
                return res;
            }catch (Exception)
            {
                return false;
            }
        }
    }
}
