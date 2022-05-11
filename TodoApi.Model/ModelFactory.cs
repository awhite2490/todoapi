using TodoApi.Model.Interface;

namespace TodoApi.Model
{
    public static class ModelFactory
    {
        public static ITodoItem GetTodoItem(string id, string text)
        {
            TodoItem result = new TodoItem(id, text);
            return result;
        }
    }
}