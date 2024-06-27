namespace Mine_Monitoring.Models
{
    public class BourseModel
    {
        public string StockName { get; set; }
        public decimal Value { get; set; }

        public string ChangeClass
        {
            get
            {
                if (Value > 0)
                {
                    return "positive";
                }
                else if (Value < 0)
                {
                    return "negative";
                }
                else
                {
                    return "zero";
                }
            }
        }
    }
}
