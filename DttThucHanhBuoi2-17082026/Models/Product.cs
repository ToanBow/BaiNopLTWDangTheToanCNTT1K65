namespace DttThucHanhBuoi2_17082026.Models;

public record Product(
    int Id,
    string Name,
    decimal Price,
    DateTime CreatedAt,
    string ImageUrl
);