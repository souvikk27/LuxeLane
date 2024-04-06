using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public class ProductImage
{
    [Key]
    public Guid Id { get; set; }
    public string MainImageUrl { get; set; }
    public string OtherImageUrl1 { get; set; }
    public string OtherImageUrl2 { get; set; }
    public string OtherImageUrl3 { get; set; }
    public string OtherImageUrl4 { get; set; }
    public string OtherImageUrl5 { get; set; }
    public string SwatchImageUrl { get; set; }
    public DateTime UploadedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }

    // Foreign key
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
}