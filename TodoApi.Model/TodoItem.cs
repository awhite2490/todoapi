using MongoDB.Bson;

using TodoApi.Model.Interface;

namespace TodoApi.Model
{
    internal sealed class TodoItem : ITodoItem
    {
        public ObjectId Id { get; set; }
        public string Text { get; set; }
        public bool IsComplete { get; set; }

        internal TodoItem(string text)
        {
            this.Text = text;
            this.IsComplete = false;
        }
    }   
}