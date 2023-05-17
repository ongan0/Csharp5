namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Role
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
