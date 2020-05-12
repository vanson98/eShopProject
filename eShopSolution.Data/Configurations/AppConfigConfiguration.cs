using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    // Phải thực thi IEntityTypeConfiguration<TEntity> thay vì EntityTypeConfiguration<TEntity> class
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            builder.HasKey(c => c.Key);
            builder.Property(c => c.Value).IsRequired(true);
        }
    }
}
