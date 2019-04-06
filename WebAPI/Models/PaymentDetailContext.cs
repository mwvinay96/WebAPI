using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {

        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentDetail>().HasData(new PaymentDetail()
            {
                PMId = 1,
                CardNumber = "1234567890123456",
                CardOwnerName = "Vinay Adiga",
                CVV = "256",
                ExpirationDate = "12/12"
            });

            modelBuilder.Entity<PaymentDetail>().HasData(new PaymentDetail()
            {
                PMId = 2,
                CardNumber = "0123456789987456",
                CardOwnerName = "Pushpendra Singh",
                CVV = "256",
                ExpirationDate = "01/12"
            });
        }
    }
}
