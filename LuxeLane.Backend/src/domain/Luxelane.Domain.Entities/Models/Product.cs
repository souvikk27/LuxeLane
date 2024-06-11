using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public decimal? Additionalshippingcharge { get; set; }

    public string? Admincomment { get; set; }

    public bool? Allowaddingonlyexistingattributecombinations { get; set; }

    public bool? Allowbackinstocksubscriptions { get; set; }

    public bool? Allowcustomerreviews { get; set; }

    public string? Allowedquantities { get; set; }

    public int? Approvedratingsum { get; set; }

    public int? Approvedtotalreviews { get; set; }

    public bool? Automaticallyaddrequiredproducts { get; set; }

    public DateTime? Availableenddatetimeutc { get; set; }

    public bool? Availableforpreorder { get; set; }

    public DateTime? Availablestartdatetimeutc { get; set; }

    public Guid? Backordermodeid { get; set; }

    public decimal? Basepriceamount { get; set; }

    public decimal? Basepricebaseamount { get; set; }

    public Guid? Basepricebaseunitid { get; set; }

    public bool? Basepriceenabled { get; set; }

    public Guid? Basepriceunitid { get; set; }

    public bool? Callforprice { get; set; }

    public DateTime? Createdonutc { get; set; }

    public bool? Customerentersprice { get; set; }

    public bool? Deleted { get; set; }

    public Guid? Deliverydateid { get; set; }

    public bool? Disablebuybutton { get; set; }

    public bool? Disablewishlistbutton { get; set; }

    public int? Displayorder { get; set; }

    public bool? Displaystockavailability { get; set; }

    public bool? Displaystockquantity { get; set; }

    public Guid? Downloadactivationtypeid { get; set; }

    public int? Downloadexpirationdays { get; set; }

    public Guid? Downloadid { get; set; }

    public string? Fulldescription { get; set; }

    public Guid? Giftcardtypeid { get; set; }

    public string? Gtin { get; set; }

    public bool? Hasdiscountsapplied { get; set; }

    public bool? Hassampledownload { get; set; }

    public bool? Hastierprices { get; set; }

    public bool? Hasuseragreement { get; set; }

    public decimal? Height { get; set; }

    public bool? Isdownload { get; set; }

    public bool? Isfreeshipping { get; set; }

    public bool? Isgiftcard { get; set; }

    public bool? Isrecurring { get; set; }

    public bool? Isrental { get; set; }

    public bool? Isshipenabled { get; set; }

    public bool? Istaxexempt { get; set; }

    public bool? Istelecommunicationsorbroadcastingorelectronicservices { get; set; }

    public decimal? Length { get; set; }

    public bool? Limitedtostores { get; set; }

    public Guid? Lowstockactivityid { get; set; }

    public Guid? Manageinventorymethodid { get; set; }

    public string? Manufacturerpartnumber { get; set; }

    public bool? Markasnew { get; set; }

    public DateTime? Markasnewenddatetimeutc { get; set; }

    public DateTime? Markasnewstartdatetimeutc { get; set; }

    public int? Maxnumberofdownloads { get; set; }

    public decimal? Maximumcustomerenteredprice { get; set; }

    public string? Metadescription { get; set; }

    public string? Metakeywords { get; set; }

    public string? Metatitle { get; set; }

    public int? Minstockquantity { get; set; }

    public decimal? Minimumcustomerenteredprice { get; set; }

    public string? Name { get; set; }

    public int? Notapprovedratingsum { get; set; }

    public int? Notapprovedtotalreviews { get; set; }

    public bool? Notreturnable { get; set; }

    public int? Notifyadminforquantitybelow { get; set; }

    public decimal? Oldprice { get; set; }

    public int? Ordermaximumquantity { get; set; }

    public int? Orderminimumquantity { get; set; }

    public decimal? Overriddengiftcardamount { get; set; }

    public Guid? Parentgroupedproductid { get; set; }

    public DateTime? Preorderavailabilitystartdatetimeutc { get; set; }

    public decimal? Price { get; set; }

    public decimal? Productcost { get; set; }

    public Guid? Producttemplateid { get; set; }

    public Guid? Producttypeid { get; set; }

    public bool? Published { get; set; }

    public int? Recurringcyclelength { get; set; }

    public Guid? Recurringcycleperiodid { get; set; }

    public int? Recurringtotalcycles { get; set; }

    public int? Rentalpricelength { get; set; }

    public Guid? Rentalpriceperiodid { get; set; }

    public bool? Requireotherproducts { get; set; }

    public string? Requiredproductids { get; set; }

    public Guid? Sampledownloadid { get; set; }

    public bool? Shipseparately { get; set; }

    public string? Shortdescription { get; set; }

    public bool? Showonhomepage { get; set; }

    public string? Sku { get; set; }

    public decimal? Specialprice { get; set; }

    public DateTime? Specialpriceenddatetimeutc { get; set; }

    public DateTime? Specialpricestartdatetimeutc { get; set; }

    public int? Stockquantity { get; set; }

    public bool? Subjecttoacl { get; set; }

    public Guid? Taxcategoryid { get; set; }

    public bool? Unlimiteddownloads { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public bool? Usemultiplewarehouses { get; set; }

    public string? Useragreementtext { get; set; }

    public Guid? Vendorid { get; set; }

    public bool? Visibleindividually { get; set; }

    public Guid? Warehouseid { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Width { get; set; }

    public virtual ICollection<Backinstocksubscription> Backinstocksubscriptions { get; set; } = new List<Backinstocksubscription>();

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();

    public virtual ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; } = new List<ProductCategoryMapping>();

    public virtual ICollection<ProductManufacturerMapping> ProductManufacturerMappings { get; set; } = new List<ProductManufacturerMapping>();

    public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; } = new List<ProductPictureMapping>();

    public virtual ICollection<ProductProductattributeMapping> ProductProductattributeMappings { get; set; } = new List<ProductProductattributeMapping>();

    public virtual ICollection<ProductSpecificationattributeMapping> ProductSpecificationattributeMappings { get; set; } = new List<ProductSpecificationattributeMapping>();

    public virtual ICollection<Productattributecombination> Productattributecombinations { get; set; } = new List<Productattributecombination>();

    public virtual ICollection<Productreview> Productreviews { get; set; } = new List<Productreview>();

    public virtual ICollection<Productwarehouseinventory> Productwarehouseinventories { get; set; } = new List<Productwarehouseinventory>();

    public virtual ICollection<Shoppingcartitem> Shoppingcartitems { get; set; } = new List<Shoppingcartitem>();

    public virtual ICollection<Tierprice> Tierprices { get; set; } = new List<Tierprice>();
}
