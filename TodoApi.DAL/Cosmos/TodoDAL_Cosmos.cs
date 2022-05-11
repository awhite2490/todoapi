using Microsoft.Azure.Cosmos;

using TodoApi.DAL.Interface;
using TodoApi.Model.Interface;
using TodoApi.Logging;
using TodoApi.Logging.Interface;

namespace TodoApi.DAL.Cosmos
{
    internal sealed class TodoDAL_Cosmos : ITodoDAL
    {
        private static readonly ILogger logger = LoggerFactory.GetLogger("TodoDAL_Cosmos");

        private readonly CosmosDatabaseSettings cosmosDatabaseSettings;

        private CosmosClient cosmosClient = null!;

        private Database database = null!;

        private Container container = null!;

        public async Task<ITodoItem> Create(string text)
        {
            throw new NotImplementedException();
        }

        public async Task<ITodoItem> Update(bool isComplete)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        private async Task Initialize()
        {
            //This would not exist in a real project
            //But need to bootstrap the cosmos database
            this.cosmosClient = new CosmosClient(this.cosmosDatabaseSettings.EndPointUri, this.cosmosDatabaseSettings.PrimaryKey);
            await this.CreateDatabase();
        }

        internal TodoDAL_Cosmos(CosmosDatabaseSettings dbSettings)
        {
            this.cosmosDatabaseSettings = dbSettings;   
        }

        private async Task CreateDatabase() 
        {
            try
            {
                this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(this.cosmosDatabaseSettings.DatabaseId);
            }
            catch(CosmosException cosmosException)
            {
                logger.Log(cosmosException.ToString(), LogLevel.Error);
            }
            catch(Exception e)
            {
                logger.Log(e.ToString(), LogLevel.Error);
            }
        }
    }
}