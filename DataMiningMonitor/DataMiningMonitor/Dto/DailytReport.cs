namespace DataMiningMonitor.Dtos
{
    /// <summary>
    /// 買賣日報表
    /// </summary>
    public class DailytReport
    {
        /// <summary>
        /// 分點
        /// </summary>
        public string BrokerId { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 買進股數
        /// </summary>
        public double Blotsum { get; set; }

        /// <summary>
        /// 賣出股數
        /// </summary>
        public double Slotsum { get; set; }
    }
}
