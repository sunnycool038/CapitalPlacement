namespace CapitalPlacementCRUD.Domain.Models
{
    public class credentials
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public string? ProductDetailsCollectionName { get; set; }
        public string? accountEndpoint { get; set; }
        public string? authKeyOrResourceToken { get; set; }
    }
}
