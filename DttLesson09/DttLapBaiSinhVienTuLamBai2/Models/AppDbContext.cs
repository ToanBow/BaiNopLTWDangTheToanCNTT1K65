using Microsoft.EntityFrameworkCore;

namespace DttLapBaiSinhVienTuLamBai2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.salePrice).HasDefaultValue(0f);
                entity.Property(e => e.Status).HasDefaultValue((byte)1);
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("getdate()");
            });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValue((byte)1);
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("getdate()");
            });
            modelBuilder.Entity<Banner>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValue((byte)1);
                entity.Property(e => e.Prioty).HasDefaultValueSql("0");
            });
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValue((byte)1);
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("getdate()");
            });


            DateTime seedDate = new DateTime(2023, 10, 1);

            // 2. Thêm dữ liệu mẫu (Seed Data) cho Category
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Điện thoại", Status = 1, CreatedDate = seedDate, Description = "Các dòng smartphone mới nhất" },
                new Category { Id = 2, Name = "Laptop", Status = 1, CreatedDate = seedDate, Description = "Máy tính xách tay các hãng" },
                new Category { Id = 3, Name = "Phụ kiện", Status = 1, CreatedDate = seedDate, Description = "Cáp, sạc, tai nghe" }
            );

            // 3. Thêm dữ liệu mẫu cho Product (CategoryId phải khớp với Id của Category ở trên)
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "iPhone 15 Pro Max", Price = 34000000, salePrice = 33000000, Status = 1, CategoryId = 1, CreatedDate = seedDate, Description = "Apple iPhone 15 Pro Max 256GB" },
                new Product { Id = 2, Name = "Samsung Galaxy S23 Ultra", Price = 25000000, salePrice = 23500000, Status = 1, CategoryId = 1, CreatedDate = seedDate, Description = "Bút S-Pen tích hợp" },
                new Product { Id = 3, Name = "MacBook Air M2", Price = 27000000, salePrice = 26000000, Status = 1, CategoryId = 2, CreatedDate = seedDate, Description = "Apple M2 chip 8-core CPU" },
                new Product { Id = 4, Name = "Tai nghe AirPods Pro 2", Price = 6000000, salePrice = 5500000, Status = 1, CategoryId = 3, CreatedDate = seedDate, Description = "Chống ồn chủ động ANC" }
            );

            // 4. Thêm dữ liệu mẫu cho Banner
            modelBuilder.Entity<Banner>().HasData(
                new Banner { Id = 1, Name = "Sale Tưng Bừng Mùa Thu", Status = 1, Prioty = 1, Description = "Giảm giá lên đến 50%" },
                new Banner { Id = 2, Name = "Mừng Ngày Nhà Giáo Việt Nam", Status = 1, Prioty = 2, Description = "Tri ân thầy cô" }
            );

            // 5. Thêm dữ liệu mẫu cho Blog
            modelBuilder.Entity<Blog>().HasData(
                new Blog { Id = 1, Name = "Đánh giá chi tiết iPhone 15 sau 1 tháng", Status = 1, CreatedDate = seedDate, Description = "Có thực sự đáng nâng cấp?" },
                new Blog { Id = 2, Name = "Top 5 Laptop sinh viên đáng mua nhất 2023", Status = 1, CreatedDate = seedDate, Description = "Cấu hình mạnh, giá rẻ" }
            );
        }
    }
}
