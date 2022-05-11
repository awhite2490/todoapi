using TodoApi.DAL.Interface;
using TodoApi.DAL.Cosmos;

namespace TodoApi.DAL
{
    public static class DALFactory
    {
        public static ITodoDAL GetTodoDAL()
        {
            CosmosDatabaseSettings cosmosDatabaseSettings = new CosmosDatabaseSettings();
            return new TodoDAL_Cosmos(cosmosDatabaseSettings);
        }
    }
}