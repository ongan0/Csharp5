namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Reviews
    {
        public Guid ID { get; set; }
        public Guid FoodID { get; set; }
        public Guid UserID { get; set; }
        public string Content { get; set; }
        public string Rating { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }

        public ICollection <Food> Food { get; set; }
        public ICollection <Users> Users { get; set; }
    }
}
