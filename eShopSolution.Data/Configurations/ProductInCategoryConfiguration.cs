using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            // Chỉ định hai khóa ngoại
            builder.HasKey(x =>new { x.CategoryId ,x.ProductId});

            // Bảng này là kết quả của liên kết n-n, do đã tạo entity nên ta tách ra làm 2 liên kết 1-n
            // builder ở đây đại diện cho Entity<ProductIncategory>, chỉ khi cấu hình ở DbContext thì mới cần chỉ định Entity
            builder.HasOne(x => x.Product)
                   .WithMany(p => p.ProductInCategories)
                   .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Category)
                   .WithMany(c => c.ProductInCategories)
                   .HasForeignKey(x => x.CategoryId);

        }
    }
}
