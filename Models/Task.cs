namespace todoapi.Models
{
  public class Task
  {
    public int Id { get; set; }
    public int Importance { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DueDate { get; set; }
    public string TimeStamp { get; set; }
    public bool Completed { get; set; }
  }
}
