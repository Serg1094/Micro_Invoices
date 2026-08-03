using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Persistence.Configs
{
    public class InvoiceConfigType : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Sales");
            /* Llave Primaria */
            builder.HasKey(x => x.OrderNumber);
            builder.Property(x => x.Price).HasColumnName("UnitPrice").IsRequired();
            builder.Property(x => x.DiscountAmount).HasColumnName("DiscountAmount").IsRequired();
            builder.Property(x => x.PromotionCode).HasColumnName("PromotionCode");

        }
    }
}
