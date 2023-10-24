namespace WorkHistory.Models
{
    public class HistoryEntry
    {
        public string WorkItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
    }
}