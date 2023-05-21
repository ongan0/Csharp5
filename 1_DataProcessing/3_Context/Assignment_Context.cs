using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._3_Context
{
    public class Assignment_Context : DbContext
    {

        public Assignment_Context()
        {

        }
        public Assignment_Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Assignment_C5_datntph19899;Persist Security Info=True;User ID=Healer;Password=1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdelDetail { get; set; }
        public DbSet<Reviews> Reviews { get; set; } 
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Express_Delivery> express_Deliveries { get; set; }
    }
}
