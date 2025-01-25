namespace GameTracker.Models
{
    public class Tracker
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Genre { get; set; }
        public string? Developer { get; set; }
        public bool IsCompleted { get; set; }
    }
}