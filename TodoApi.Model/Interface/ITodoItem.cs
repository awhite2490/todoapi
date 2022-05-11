namespace TodoApi.Model.Interface
{
    public interface ITodoItem
    {
           string Id { get; set; }
           string Text { get; set; }
           bool IsComplete { get; set; }
    }
}