using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Infrastructure
{
    public class InventoryMapping : IEntityTypeConfiguration<Domain.Inventory>
    {
        public void Configure(EntityTypeBuilder<Domain.Inventory> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
