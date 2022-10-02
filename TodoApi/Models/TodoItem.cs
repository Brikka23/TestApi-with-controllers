namespace TodoApi.Models
{
    public class TodoItem
    {
        public long ID { get; set; }
        public string? name { get; set; }
        public bool IsComplete { get; set; }
    }
}
