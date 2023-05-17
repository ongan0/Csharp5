namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Category
    {
        public Guid ID { get; set; }
        public Guid FoodID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Food> Food { get; set; }
        public ICollection<Combo> combos { get; set; }
    }
}
