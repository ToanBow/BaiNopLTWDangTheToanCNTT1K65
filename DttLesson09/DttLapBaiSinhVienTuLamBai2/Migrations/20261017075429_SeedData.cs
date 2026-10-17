using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DttLapBaiSinhVienTuLamBai2.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "Description", "Image", "Name", "Prioty", "Status" },
                values: new object[,]
                {
                    { 1, "Giảm giá lên đến 50%", null, "Sale Tưng Bừng Mùa Thu", 1, (byte)1 },
                    { 2, "Tri ân thầy cô", null, "Mừng Ngày Nhà Giáo Việt Nam", 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Có thực sự đáng nâng cấp?", null, "Đánh giá chi tiết iPhone 15 sau 1 tháng", (byte)1 },
                    { 2, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cấu hình mạnh, giá rẻ", null, "Top 5 Laptop sinh viên đáng mua nhất 2023", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Các dòng smartphone mới nhất", null, "Điện thoại", (byte)1 },
                    { 2, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Máy tính xách tay các hãng", null, "Laptop", (byte)1 },
                    { 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cáp, sạc, tai nghe", null, "Phụ kiện", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Image", "Name", "Price", "Status", "salePrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple iPhone 15 Pro Max 256GB", null, "iPhone 15 Pro Max", 34000000f, (byte)1, 33000000f },
                    { 2, 1, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bút S-Pen tích hợp", null, "Samsung Galaxy S23 Ultra", 25000000f, (byte)1, 23500000f },
                    { 3, 2, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple M2 chip 8-core CPU", null, "MacBook Air M2", 27000000f, (byte)1, 26000000f },
                    { 4, 3, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chống ồn chủ động ANC", null, "Tai nghe AirPods Pro 2", 6000000f, (byte)1, 5500000f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
