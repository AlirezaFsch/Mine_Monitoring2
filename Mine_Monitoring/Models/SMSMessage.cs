using System;

namespace Mine_Monitoring.Models
{
    public class SMSMessage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public int SMSTypeId { get; set; }
        public SMSType SMSType { get; set; }
        public string Message { get; set; }
        public DateTime SentDateTime { get; set; }
    }
}
