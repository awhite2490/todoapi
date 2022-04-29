using TodoApi.Model.Interface;

namespace TodoApi.Model
{
    public static class ModelFactory
    {
        public static ITodoItem GetTodoItem(string text)
        {
            TodoItem result = new TodoItem(text);
            return result;
        }
    }
}