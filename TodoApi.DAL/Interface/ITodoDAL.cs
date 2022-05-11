using TodoApi.Model.Interface;

namespace TodoApi.DAL.Interface
{
    public interface ITodoDAL
    {
        Task<ITodoItem> Create(string text);
        Task<ITodoItem> Update(bool isComplete);
        Task Delete(string id);
    }
}