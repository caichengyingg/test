namespace Report.Core
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateTime { get; set; }
        public string StoreId { get; set; }
        public string OpenId { get; set; }
        public string Mobile { get; set; }
        /// <summary>
        /// 状态：1、使用；2、不使用
        /// </summary>
        public int Status { get; set; }                                                                               
    }
}
