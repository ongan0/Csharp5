namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class OrderDetail
    {
        public Guid ID { get; set; }
        public Guid OrderID { get; set; }
        public Guid FoodID { get; set; }
        public int Quantity { get; set; }

        public ICollection<Food> Food { get; set; }
        public virtual Order Order { get; set; }
    }
}
