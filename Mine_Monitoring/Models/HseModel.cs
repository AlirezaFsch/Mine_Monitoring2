namespace Mine_Monitoring.Models
{
    public class HseCourse
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
    }
}