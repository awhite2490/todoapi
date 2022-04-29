using MongoDB.Bson;

namespace TodoApi.Model.Interface
{
    public interface ITodoItem
    {
           ObjectId Id { get; set; }
           string Text { get; set; }
           bool IsComplete { get; set; }
    }
}