using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using TodoApi.Model.Interface;

namespace TodoApi.Model
{
    internal sealed class TodoItem : ITodoItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        [BsonElement("Text")]
        public string Text { get; set; }
        [BsonElement("IsComplete")]
        public bool IsComplete { get; set; }

        internal TodoItem(string text)
        {
            this.Text = text;
            this.IsComplete = false;
        }
    }   
}