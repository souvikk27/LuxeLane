namespace Luxelane.Domain.Entities.Models;

public partial class Category
{
    public Guid Id { get; set; }

    public bool? Allowcustomerstoselectpagesize { get; set; }

    public Guid? Categorytemplateid { get; set; }

    public DateTime? Createdonutc { get; set; }

    public bool? Deleted { get; set; }

    public string? Description { get; set; }

    public Guid? Displayorder { get; set; }

    public bool? Includeintopmenu { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Metadescription { get; set; }

    public string? Metakeywords { get; set; }

    public string? Metatitle { get; set; }

    public string? Name { get; set; }

    public Guid? Pagesize { get; set; }

    public string? Pagesizeoptions { get; set; }

    public Guid? Parentcategoryid { get; set; }

    public Guid? Pictureid { get; set; }

    public string? Priceranges { get; set; }

    public bool? Published { get; set; }

    public bool? Showonhomepage { get; set; }

    public bool? Subjecttoacl { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public virtual ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; } = new List<ProductCategoryMapping>();
}
