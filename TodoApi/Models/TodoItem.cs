namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? name { get; set; }
        public bool IsComplete { get; set; }
    }
}
