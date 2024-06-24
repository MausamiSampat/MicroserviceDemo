using MicroserviceDemo.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceDemo.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Coupon> Coupons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "5OFF",
                DiscountAmount = 5,
                MinAmount = 10
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "10OFF",
                DiscountAmount = 10,
                MinAmount = 20
            });
        }
    }
}
