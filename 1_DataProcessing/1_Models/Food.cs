namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Food
    {
        public Guid ID { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public virtual Combo Combo { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
        public ICollection<Coupons> Coupons { get; set; }
    }
}
