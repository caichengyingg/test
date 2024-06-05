namespace Report.Core
{
    public class Custom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        /// <summary>
        /// 1、普通客户；2、楼盘
        /// </summary>
        public int Type { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
