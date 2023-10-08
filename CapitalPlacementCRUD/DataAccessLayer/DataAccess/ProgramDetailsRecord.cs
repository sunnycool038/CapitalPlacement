using CapitalPlacementConsole.Models;
using CapitalPlacementCRUD.Domain.Interface;
using CapitalPlacementCRUD.Domain.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Options;

namespace CapitalPlacementCRUD.DataAccessLayer.DataAccess
{
    public class ProgramDetailsRecord : IProgramDetailsRecord
    {
        private readonly credentials _credentials;
        public ProgramDetailsRecord(IOptions<credentials> credentials)
        {
            _credentials = credentials.Value;
        }

        public async Task<bool> Create(ProgramDetailsDB newBook)
        {
            bool response = false;
            try
            {
                CosmosClient client = new(accountEndpoint: _credentials.accountEndpoint, authKeyOrResourceToken: _credentials.authKeyOrResourceToken);
                Database database = await client.CreateDatabaseIfNotExistsAsync(id: _credentials.DatabaseName, throughput: 1000);
                Container container = await database.CreateContainerIfNotExistsAsync(id: _credentials.ProductDetailsCollectionName, partitionKeyPath: "/id");
                ProgramDetailsDB t = await container.UpsertItemAsync(newBook);
                response = true;
            }
            catch(Exception ex)
            {
                return response;
            }
            return response;
        }

        //public async Task<bool> Put(int newBook)
        //{
        //    bool response = false;
        //    CosmosClient client = new(accountEndpoint: _credentials.accountEndpoint, authKeyOrResourceToken: _credentials.authKeyOrResourceToken);
        //    Database database = await client.CreateDatabaseIfNotExistsAsync(id: _credentials.DatabaseName, throughput: 40);
        //    Container container = await database.CreateContainerIfNotExistsAsync(id: _credentials.ProductDetailsCollectionName, partitionKeyPath: "/id");
        //    try
        //    {
        //        await container.ReplaceContainerAsync(newBook);
        //        response = true;
        //    }
        //    catch (Exception)
        //    {
        //        return response;
        //    }
        //    return response;
        //}

        public async Task<bool> Get(string Id)
        {
            bool response = false;
            CosmosClient client = new(accountEndpoint: _credentials.accountEndpoint, authKeyOrResourceToken: _credentials.authKeyOrResourceToken);
            Database database = await client.CreateDatabaseIfNotExistsAsync(id: _credentials.DatabaseName, throughput: 40);
            Container container = await database.CreateContainerIfNotExistsAsync(id: _credentials.ProductDetailsCollectionName, partitionKeyPath: "/id");
            try
            {
                await container.UpsertItemAsync(Id);
                response = true;
            }
            catch (Exception)
            {
                return response;
            }
            return response;
        }
    }
}
