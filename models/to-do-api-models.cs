namespace to_do_api.Models
{
  public class ToDoItem
  {
    public int Id { get; set; }
    public required string Title { get; set; }
    public bool IsCompleted { get; set; }
  }
}