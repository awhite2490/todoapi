namespace TodoApi.DAL.Cosmos
{
    public struct CosmosDatabaseSettings
    {
        private const string endpointUrl = "https://awhite2490-test.documents.azure.com:443/";
        private const string primaryKey = "";
        public string EndpointUri { get { return endpointUrl; } }
        public string PrimaryKey{ get { return primaryKey; } }
        public string DatabaseId { get; set; }
        public string ContainerId { get; set; }
    }
}