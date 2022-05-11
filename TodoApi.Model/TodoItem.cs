using TodoApi.Model.Interface;

namespace TodoApi.Model
{
    internal sealed class TodoItem : ITodoItem
    {
        public string Id { get; set; }
        
        public string Text { get; set; }
        
        public bool IsComplete { get; set; }

        internal TodoItem(string id, string text)
        {
            this.Id = id;
            this.Text = text;
            this.IsComplete = false;
        }
    }   
}