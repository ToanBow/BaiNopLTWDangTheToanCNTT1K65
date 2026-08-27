namespace DttThucHanhBuoi3_21082026.Models
{
    public record CategoryDto(int Id, string Name);
    public record ProductDto(
        int Id, 
        int CategoryId,
        string Name,
        decimal OriginalPrice,
        decimal SalePrice,
        string Description,
        bool Instock,
        DateTime CreateAt,
        string ImageUrl
    );
    public record ProductCatalogViewModel(
        IReadOnlyList<CategoryDto> Categories,
        IReadOnlyList<ProductDto> Products,
        int? SelectedCategoryId
    );
}
