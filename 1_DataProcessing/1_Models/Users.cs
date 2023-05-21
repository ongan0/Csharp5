namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Users
    {
        public Guid ID { get; set; }
        public Guid IDRole { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Status { get; set; }

        public virtual Role Role { get; set; }
        public ICollection<Bill> Bills { get; set; }
        //public ICollection<Express_Delivery> Express_Delivery { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
