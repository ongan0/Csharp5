namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Bill
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Users Users { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
        public virtual Express_Delivery Express_Delivery { get; set; }
    }
}
