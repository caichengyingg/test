namespace Report.Core
{
    public class Report
    {
        public int Id { get; set; }
        public int UserId {  get; set; }
        public DateTime CreateTime { get; set; }
        public int ReceptionCustoms { get;set; }
        public int TransactionCustoms { get;set; }
        public double TransactionAmount { get; set; }
        public string ReceptionRemark { get; set; }
        public int FollowupCustoms { get; set; }
        public string FollowupRemark { get; set; }
        public DateTime OnDate { get;set; }
    }
}
