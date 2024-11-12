namespace build_analysis.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}