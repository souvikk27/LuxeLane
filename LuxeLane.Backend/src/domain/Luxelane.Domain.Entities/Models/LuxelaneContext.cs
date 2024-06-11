using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Luxelane.Domain.Entities.Models;

public partial class LuxelaneContext : DbContext
{
    public LuxelaneContext()
    {
    }

    public LuxelaneContext(DbContextOptions<LuxelaneContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aclrecord> Aclrecords { get; set; }

    public virtual DbSet<Activitylog> Activitylogs { get; set; }

    public virtual DbSet<Activitylogtype> Activitylogtypes { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Addressattribute> Addressattributes { get; set; }

    public virtual DbSet<Addressattributevalue> Addressattributevalues { get; set; }

    public virtual DbSet<Affiliate> Affiliates { get; set; }

    public virtual DbSet<Backinstocksubscription> Backinstocksubscriptions { get; set; }

    public virtual DbSet<Blogcomment> Blogcomments { get; set; }

    public virtual DbSet<Blogpost> Blogposts { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Categorytemplate> Categorytemplates { get; set; }

    public virtual DbSet<Checkoutattribute> Checkoutattributes { get; set; }

    public virtual DbSet<Checkoutattributevalue> Checkoutattributevalues { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Crosssellproduct> Crosssellproducts { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerCustomerroleMapping> CustomerCustomerroleMappings { get; set; }

    public virtual DbSet<Customeraddress> Customeraddresses { get; set; }

    public virtual DbSet<Customerattribute> Customerattributes { get; set; }

    public virtual DbSet<Customerattributevalue> Customerattributevalues { get; set; }

    public virtual DbSet<Customerrole> Customerroles { get; set; }

    public virtual DbSet<Deliverydate> Deliverydates { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<DiscountAppliedtocategory> DiscountAppliedtocategories { get; set; }

    public virtual DbSet<DiscountAppliedtomanufacturer> DiscountAppliedtomanufacturers { get; set; }

    public virtual DbSet<DiscountAppliedtoproduct> DiscountAppliedtoproducts { get; set; }

    public virtual DbSet<Discountrequirement> Discountrequirements { get; set; }

    public virtual DbSet<Discountusagehistory> Discountusagehistories { get; set; }

    public virtual DbSet<Download> Downloads { get; set; }

    public virtual DbSet<Emailaccount> Emailaccounts { get; set; }

    public virtual DbSet<Externalauthenticationrecord> Externalauthenticationrecords { get; set; }

    public virtual DbSet<ForumsForum> ForumsForums { get; set; }

    public virtual DbSet<ForumsGroup> ForumsGroups { get; set; }

    public virtual DbSet<ForumsPost> ForumsPosts { get; set; }

    public virtual DbSet<ForumsPostvote> ForumsPostvotes { get; set; }

    public virtual DbSet<ForumsPrivatemessage> ForumsPrivatemessages { get; set; }

    public virtual DbSet<ForumsSubscription> ForumsSubscriptions { get; set; }

    public virtual DbSet<ForumsTopic> ForumsTopics { get; set; }

    public virtual DbSet<Genericattribute> Genericattributes { get; set; }

    public virtual DbSet<Giftcard> Giftcards { get; set; }

    public virtual DbSet<Giftcardusagehistory> Giftcardusagehistories { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Localestringresource> Localestringresources { get; set; }

    public virtual DbSet<Localizedproperty> Localizedproperties { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Manufacturertemplate> Manufacturertemplates { get; set; }

    public virtual DbSet<Measuredimension> Measuredimensions { get; set; }

    public virtual DbSet<Measureweight> Measureweights { get; set; }

    public virtual DbSet<Messagetemplate> Messagetemplates { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<Newscomment> Newscomments { get; set; }

    public virtual DbSet<Newslettersubscription> Newslettersubscriptions { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Orderitem> Orderitems { get; set; }

    public virtual DbSet<Ordernote> Ordernotes { get; set; }

    public virtual DbSet<Permissionrecord> Permissionrecords { get; set; }

    public virtual DbSet<PermissionrecordRoleMapping> PermissionrecordRoleMappings { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<Poll> Polls { get; set; }

    public virtual DbSet<Pollanswer> Pollanswers { get; set; }

    public virtual DbSet<Pollvotingrecord> Pollvotingrecords { get; set; }

    public virtual DbSet<Predefinedproductattributevalue> Predefinedproductattributevalues { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }

    public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }

    public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }

    public virtual DbSet<ProductProductattributeMapping> ProductProductattributeMappings { get; set; }

    public virtual DbSet<ProductProducttagMapping> ProductProducttagMappings { get; set; }

    public virtual DbSet<ProductSpecificationattributeMapping> ProductSpecificationattributeMappings { get; set; }

    public virtual DbSet<Productattribute> Productattributes { get; set; }

    public virtual DbSet<Productattributecombination> Productattributecombinations { get; set; }

    public virtual DbSet<Productattributevalue> Productattributevalues { get; set; }

    public virtual DbSet<Productreview> Productreviews { get; set; }

    public virtual DbSet<Productreviewhelpfulness> Productreviewhelpfulnesses { get; set; }

    public virtual DbSet<Producttag> Producttags { get; set; }

    public virtual DbSet<Producttemplate> Producttemplates { get; set; }

    public virtual DbSet<Productwarehouseinventory> Productwarehouseinventories { get; set; }

    public virtual DbSet<Queuedemail> Queuedemails { get; set; }

    public virtual DbSet<Recurringpayment> Recurringpayments { get; set; }

    public virtual DbSet<Recurringpaymenthistory> Recurringpaymenthistories { get; set; }

    public virtual DbSet<Relatedproduct> Relatedproducts { get; set; }

    public virtual DbSet<Returnrequest> Returnrequests { get; set; }

    public virtual DbSet<Returnrequestaction> Returnrequestactions { get; set; }

    public virtual DbSet<Returnrequestreason> Returnrequestreasons { get; set; }

    public virtual DbSet<Rewardpointshistory> Rewardpointshistories { get; set; }

    public virtual DbSet<Scheduletask> Scheduletasks { get; set; }

    public virtual DbSet<Searchterm> Searchterms { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<Shipmentitem> Shipmentitems { get; set; }

    public virtual DbSet<Shippingmethod> Shippingmethods { get; set; }

    public virtual DbSet<Shippingmethodrestriction> Shippingmethodrestrictions { get; set; }

    public virtual DbSet<Shoppingcartitem> Shoppingcartitems { get; set; }

    public virtual DbSet<Specificationattribute> Specificationattributes { get; set; }

    public virtual DbSet<Specificationattributeoption> Specificationattributeoptions { get; set; }

    public virtual DbSet<Stateprovince> Stateprovinces { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Storemapping> Storemappings { get; set; }

    public virtual DbSet<Taxcategory> Taxcategories { get; set; }

    public virtual DbSet<Tierprice> Tierprices { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<Topictemplate> Topictemplates { get; set; }

    public virtual DbSet<Urlrecord> Urlrecords { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<Vendornote> Vendornotes { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=luxelane;Username=postgres;Password=Sou@2345");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aclrecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_aclrecord");

            entity.ToTable("aclrecord");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Customerroleid).HasColumnName("customerroleid");
            entity.Property(e => e.Entityid).HasColumnName("entityid");
            entity.Property(e => e.Entityname)
                .HasMaxLength(400)
                .HasColumnName("entityname");

            entity.HasOne(d => d.Customerrole).WithMany(p => p.Aclrecords)
                .HasForeignKey(d => d.Customerroleid)
                .HasConstraintName("fk_aclrecord_customerrole_id");
        });

        modelBuilder.Entity<Activitylog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activitylog_pkey");

            entity.ToTable("activitylog");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Activitylogtypeid).HasColumnName("activitylogtypeid");
            entity.Property(e => e.Comment)
                .HasMaxLength(4000)
                .HasColumnName("comment");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(200)
                .HasColumnName("ipaddress");

            entity.HasOne(d => d.Activitylogtype).WithMany(p => p.Activitylogs)
                .HasForeignKey(d => d.Activitylogtypeid)
                .HasConstraintName("fk_activitylog_activitylogtype_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Activitylogs)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_activitylog_customer_id");
        });

        modelBuilder.Entity<Activitylogtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activitylogtype_pkey");

            entity.ToTable("activitylogtype");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Systemkeyword)
                .HasMaxLength(100)
                .HasColumnName("systemkeyword");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("address_pkey");

            entity.ToTable("address");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasMaxLength(4000)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(4000)
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasMaxLength(4000)
                .HasColumnName("city");
            entity.Property(e => e.Company)
                .HasMaxLength(4000)
                .HasColumnName("company");
            entity.Property(e => e.Countryid).HasColumnName("countryid");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customattributes)
                .HasMaxLength(4000)
                .HasColumnName("customattributes");
            entity.Property(e => e.Email)
                .HasMaxLength(4000)
                .HasColumnName("email");
            entity.Property(e => e.Faxnumber)
                .HasMaxLength(4000)
                .HasColumnName("faxnumber");
            entity.Property(e => e.Firstname)
                .HasMaxLength(4000)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(4000)
                .HasColumnName("lastname");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(4000)
                .HasColumnName("phonenumber");
            entity.Property(e => e.Stateprovinceid).HasColumnName("stateprovinceid");
            entity.Property(e => e.Zippostalcode)
                .HasMaxLength(4000)
                .HasColumnName("zippostalcode");

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.Countryid)
                .HasConstraintName("fk_address_country_id");

            entity.HasOne(d => d.Stateprovince).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.Stateprovinceid)
                .HasConstraintName("fk_address_stateprovince_id");
        });

        modelBuilder.Entity<Addressattribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("addressattribute_pkey");

            entity.ToTable("addressattribute");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attributecontroltypeid).HasColumnName("attributecontroltypeid");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Isrequired).HasColumnName("isrequired");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Addressattributevalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("addressattributevalue_pkey");

            entity.ToTable("addressattributevalue");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Addressattributeid).HasColumnName("addressattributeid");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Ispreselected).HasColumnName("ispreselected");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");

            entity.HasOne(d => d.Addressattribute).WithMany(p => p.Addressattributevalues)
                .HasForeignKey(d => d.Addressattributeid)
                .HasConstraintName("fk_addressattributevalue_addressattribute_id");
        });

        modelBuilder.Entity<Affiliate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("affiliate_pkey");

            entity.ToTable("affiliate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Addressid).HasColumnName("addressid");
            entity.Property(e => e.Admincomment)
                .HasMaxLength(4000)
                .HasColumnName("admincomment");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Friendlyurlname)
                .HasMaxLength(4000)
                .HasColumnName("friendlyurlname");

            entity.HasOne(d => d.Address).WithMany(p => p.Affiliates)
                .HasForeignKey(d => d.Addressid)
                .HasConstraintName("fk_affiliate_address_id");
        });

        modelBuilder.Entity<Backinstocksubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("backinstocksubscription_pkey");

            entity.ToTable("backinstocksubscription");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Storeid).HasColumnName("storeid");

            entity.HasOne(d => d.Customer).WithMany(p => p.Backinstocksubscriptions)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_backinstocksubscription_customer_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Backinstocksubscriptions)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_backinstocksubscription_product_id");
        });

        modelBuilder.Entity<Blogcomment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("blogcomment_pkey");

            entity.ToTable("blogcomment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Blogpostid).HasColumnName("blogpostid");
            entity.Property(e => e.Commenttext)
                .HasMaxLength(4000)
                .HasColumnName("commenttext");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");

            entity.HasOne(d => d.Blogpost).WithMany(p => p.Blogcomments)
                .HasForeignKey(d => d.Blogpostid)
                .HasConstraintName("fk_blogcomment_blogpost_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Blogcomments)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_blogcomment_customer_id");
        });

        modelBuilder.Entity<Blogpost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("blogpost_pkey");

            entity.ToTable("blogpost");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Allowcomments).HasColumnName("allowcomments");
            entity.Property(e => e.Body)
                .HasMaxLength(4000)
                .HasColumnName("body");
            entity.Property(e => e.Bodyoverview)
                .HasMaxLength(4000)
                .HasColumnName("bodyoverview");
            entity.Property(e => e.Commentcount).HasColumnName("commentcount");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Enddateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("enddateutc");
            entity.Property(e => e.Languageid).HasColumnName("languageid");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(4000)
                .HasColumnName("metadescription");
            entity.Property(e => e.Metakeywords)
                .HasMaxLength(400)
                .HasColumnName("metakeywords");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(400)
                .HasColumnName("metatitle");
            entity.Property(e => e.Startdateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("startdateutc");
            entity.Property(e => e.Tags)
                .HasMaxLength(4000)
                .HasColumnName("tags");
            entity.Property(e => e.Title)
                .HasMaxLength(4000)
                .HasColumnName("title");

            entity.HasOne(d => d.Language).WithMany(p => p.Blogposts)
                .HasForeignKey(d => d.Languageid)
                .HasConstraintName("fk_blogpost_language_id");
        });

        modelBuilder.Entity<Campaign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("campaign_pkey");

            entity.ToTable("campaign");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Body)
                .HasMaxLength(4000)
                .HasColumnName("body");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerroleid).HasColumnName("customerroleid");
            entity.Property(e => e.Dontsendbeforedateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dontsendbeforedateutc");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Subject)
                .HasMaxLength(4000)
                .HasColumnName("subject");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("category_pkey");

            entity.ToTable("category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Allowcustomerstoselectpagesize).HasColumnName("allowcustomerstoselectpagesize");
            entity.Property(e => e.Categorytemplateid).HasColumnName("categorytemplateid");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Includeintopmenu).HasColumnName("includeintopmenu");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(4000)
                .HasColumnName("metadescription");
            entity.Property(e => e.Metakeywords)
                .HasMaxLength(400)
                .HasColumnName("metakeywords");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(400)
                .HasColumnName("metatitle");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Pagesize).HasColumnName("pagesize");
            entity.Property(e => e.Pagesizeoptions)
                .HasMaxLength(200)
                .HasColumnName("pagesizeoptions");
            entity.Property(e => e.Parentcategoryid).HasColumnName("parentcategoryid");
            entity.Property(e => e.Pictureid).HasColumnName("pictureid");
            entity.Property(e => e.Priceranges)
                .HasMaxLength(400)
                .HasColumnName("priceranges");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Showonhomepage).HasColumnName("showonhomepage");
            entity.Property(e => e.Subjecttoacl).HasColumnName("subjecttoacl");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");
        });

        modelBuilder.Entity<Categorytemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorytemplate_pkey");

            entity.ToTable("categorytemplate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Viewpath)
                .HasMaxLength(400)
                .HasColumnName("viewpath");
        });

        modelBuilder.Entity<Checkoutattribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("checkoutattribute_pkey");

            entity.ToTable("checkoutattribute");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attributecontroltypeid).HasColumnName("attributecontroltypeid");
            entity.Property(e => e.Conditionattributexml)
                .HasMaxLength(4000)
                .HasColumnName("conditionattributexml");
            entity.Property(e => e.Defaultvalue)
                .HasMaxLength(4000)
                .HasColumnName("defaultvalue");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Isrequired).HasColumnName("isrequired");
            entity.Property(e => e.Istaxexempt).HasColumnName("istaxexempt");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Shippableproductrequired).HasColumnName("shippableproductrequired");
            entity.Property(e => e.Taxcategoryid).HasColumnName("taxcategoryid");
            entity.Property(e => e.Textprompt)
                .HasMaxLength(4000)
                .HasColumnName("textprompt");
            entity.Property(e => e.Validationfileallowedextensions)
                .HasMaxLength(4000)
                .HasColumnName("validationfileallowedextensions");
            entity.Property(e => e.Validationfilemaximumsize).HasColumnName("validationfilemaximumsize");
            entity.Property(e => e.Validationmaxlength).HasColumnName("validationmaxlength");
            entity.Property(e => e.Validationminlength).HasColumnName("validationminlength");
        });

        modelBuilder.Entity<Checkoutattributevalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("checkoutattributevalue_pkey");

            entity.ToTable("checkoutattributevalue");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Checkoutattributeid).HasColumnName("checkoutattributeid");
            entity.Property(e => e.Colorsquaresrgb)
                .HasMaxLength(100)
                .HasColumnName("colorsquaresrgb");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Ispreselected).HasColumnName("ispreselected");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Priceadjustment)
                .HasPrecision(18, 4)
                .HasColumnName("priceadjustment");
            entity.Property(e => e.Weightadjustment)
                .HasPrecision(18, 4)
                .HasColumnName("weightadjustment");

            entity.HasOne(d => d.Checkoutattribute).WithMany(p => p.Checkoutattributevalues)
                .HasForeignKey(d => d.Checkoutattributeid)
                .HasConstraintName("fk_checkoutattributevalue_checkoutattribute_id");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("country_pkey");

            entity.ToTable("country");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Allowsbilling).HasColumnName("allowsbilling");
            entity.Property(e => e.Allowsshipping).HasColumnName("allowsshipping");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Numericisocode).HasColumnName("numericisocode");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Subjecttovat).HasColumnName("subjecttovat");
            entity.Property(e => e.Threeletterisocode)
                .HasMaxLength(3)
                .HasColumnName("threeletterisocode");
            entity.Property(e => e.Twoletterisocode)
                .HasMaxLength(2)
                .HasColumnName("twoletterisocode");
        });

        modelBuilder.Entity<Crosssellproduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crosssellproduct_pkey");

            entity.ToTable("crosssellproduct");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Productid1).HasColumnName("productid1");
            entity.Property(e => e.Productid2).HasColumnName("productid2");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("currency_pkey");

            entity.ToTable("currency");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Currencycode)
                .HasMaxLength(5)
                .HasColumnName("currencycode");
            entity.Property(e => e.Customformatting)
                .HasMaxLength(50)
                .HasColumnName("customformatting");
            entity.Property(e => e.Displaylocale)
                .HasMaxLength(50)
                .HasColumnName("displaylocale");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Rate)
                .HasPrecision(18, 4)
                .HasColumnName("rate");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("customer_pkey");

            entity.ToTable("customer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Admincomment)
                .HasMaxLength(4000)
                .HasColumnName("admincomment");
            entity.Property(e => e.Affiliateid).HasColumnName("affiliateid");
            entity.Property(e => e.BillingaddressId).HasColumnName("billingaddress_id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerguid).HasColumnName("customerguid");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Email)
                .HasMaxLength(1000)
                .HasColumnName("email");
            entity.Property(e => e.Hasshoppingcartitems).HasColumnName("hasshoppingcartitems");
            entity.Property(e => e.Issystemaccount).HasColumnName("issystemaccount");
            entity.Property(e => e.Istaxexempt).HasColumnName("istaxexempt");
            entity.Property(e => e.Lastactivitydateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastactivitydateutc");
            entity.Property(e => e.Lastipaddress)
                .HasMaxLength(4000)
                .HasColumnName("lastipaddress");
            entity.Property(e => e.Lastlogindateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastlogindateutc");
            entity.Property(e => e.Password)
                .HasMaxLength(4000)
                .HasColumnName("password");
            entity.Property(e => e.Passwordformatid).HasColumnName("passwordformatid");
            entity.Property(e => e.Passwordsalt)
                .HasMaxLength(4000)
                .HasColumnName("passwordsalt");
            entity.Property(e => e.ShippingaddressId).HasColumnName("shippingaddress_id");
            entity.Property(e => e.Systemname)
                .HasMaxLength(400)
                .HasColumnName("systemname");
            entity.Property(e => e.Username)
                .HasMaxLength(1000)
                .HasColumnName("username");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");

            entity.HasOne(d => d.Billingaddress).WithMany(p => p.CustomerBillingaddresses)
                .HasForeignKey(d => d.BillingaddressId)
                .HasConstraintName("fk_customer_address_id");

            entity.HasOne(d => d.Shippingaddress).WithMany(p => p.CustomerShippingaddresses)
                .HasForeignKey(d => d.ShippingaddressId)
                .HasConstraintName("fk_customer_ship_address_id");
        });

        modelBuilder.Entity<CustomerCustomerroleMapping>(entity =>
        {
            entity.HasKey(e => new { e.CustomerroleId, e.CustomerId }).HasName("customer_customerrole_mapping_pkey");

            entity.ToTable("customer_customerrole_mapping");

            entity.Property(e => e.CustomerroleId).HasColumnName("customerrole_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
        });

        modelBuilder.Entity<Customeraddress>(entity =>
        {
            entity.HasKey(e => new { e.AddressId, e.CustomerId }).HasName("customeraddresses_pkey");

            entity.ToTable("customeraddresses");

            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
        });

        modelBuilder.Entity<Customerattribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("customerattribute_pkey");

            entity.ToTable("customerattribute");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attributecontroltypeid).HasColumnName("attributecontroltypeid");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Isrequired).HasColumnName("isrequired");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Customerattributevalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("customerattributevalue_pkey");

            entity.ToTable("customerattributevalue");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Customerattributeid).HasColumnName("customerattributeid");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Ispreselected).HasColumnName("ispreselected");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");

            entity.HasOne(d => d.Customerattribute).WithMany(p => p.Customerattributevalues)
                .HasForeignKey(d => d.Customerattributeid)
                .HasConstraintName("fk_customerattributevalue_customerattribute_id");
        });

        modelBuilder.Entity<Customerrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("customerrole_pkey");

            entity.ToTable("customerrole");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Freeshipping).HasColumnName("freeshipping");
            entity.Property(e => e.Issystemrole).HasColumnName("issystemrole");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Purchasedwithproductid).HasColumnName("purchasedwithproductid");
            entity.Property(e => e.Systemname)
                .HasMaxLength(255)
                .HasColumnName("systemname");
            entity.Property(e => e.Taxexempt).HasColumnName("taxexempt");
        });

        modelBuilder.Entity<Deliverydate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("deliverydate_pkey");

            entity.ToTable("deliverydate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("discount_pkey");

            entity.ToTable("discount");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Appliedtosubcategories).HasColumnName("appliedtosubcategories");
            entity.Property(e => e.Couponcode)
                .HasMaxLength(100)
                .HasColumnName("couponcode");
            entity.Property(e => e.Discountamount)
                .HasPrecision(18, 4)
                .HasColumnName("discountamount");
            entity.Property(e => e.Discountlimitationid).HasColumnName("discountlimitationid");
            entity.Property(e => e.Discountpercentage)
                .HasPrecision(18, 4)
                .HasColumnName("discountpercentage");
            entity.Property(e => e.Discounttypeid).HasColumnName("discounttypeid");
            entity.Property(e => e.Enddateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("enddateutc");
            entity.Property(e => e.Iscumulative).HasColumnName("iscumulative");
            entity.Property(e => e.Limitationtimes).HasColumnName("limitationtimes");
            entity.Property(e => e.Maximumdiscountamount)
                .HasPrecision(18, 4)
                .HasColumnName("maximumdiscountamount");
            entity.Property(e => e.Maximumdiscountedquantity).HasColumnName("maximumdiscountedquantity");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Requirescouponcode).HasColumnName("requirescouponcode");
            entity.Property(e => e.Startdateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("startdateutc");
            entity.Property(e => e.Usepercentage).HasColumnName("usepercentage");
        });

        modelBuilder.Entity<DiscountAppliedtocategory>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.DiscountId }).HasName("discount_appliedtocategories_pkey");

            entity.ToTable("discount_appliedtocategories");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.DiscountId).HasColumnName("discount_id");
        });

        modelBuilder.Entity<DiscountAppliedtomanufacturer>(entity =>
        {
            entity.HasKey(e => new { e.DiscountId, e.ManufacturerId }).HasName("discount_appliedtomanufacturers_pkey");

            entity.ToTable("discount_appliedtomanufacturers");

            entity.Property(e => e.DiscountId).HasColumnName("discount_id");
            entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");
        });

        modelBuilder.Entity<DiscountAppliedtoproduct>(entity =>
        {
            entity.HasKey(e => new { e.DiscountId, e.ProductId }).HasName("discount_appliedtoproducts_pkey");

            entity.ToTable("discount_appliedtoproducts");

            entity.Property(e => e.DiscountId).HasColumnName("discount_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
        });

        modelBuilder.Entity<Discountrequirement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("discountrequirement_pkey");

            entity.ToTable("discountrequirement");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Discountid).HasColumnName("discountid");
            entity.Property(e => e.Discountrequirementrulesystemname)
                .HasMaxLength(4000)
                .HasColumnName("discountrequirementrulesystemname");

            entity.HasOne(d => d.Discount).WithMany(p => p.Discountrequirements)
                .HasForeignKey(d => d.Discountid)
                .HasConstraintName("fk_discountrequirement_discount_id");
        });

        modelBuilder.Entity<Discountusagehistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("discountusagehistory_pkey");

            entity.ToTable("discountusagehistory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Discountid).HasColumnName("discountid");
            entity.Property(e => e.Orderid).HasColumnName("orderid");

            entity.HasOne(d => d.Discount).WithMany(p => p.Discountusagehistories)
                .HasForeignKey(d => d.Discountid)
                .HasConstraintName("fk_discountusagehistory_discount_id");

            entity.HasOne(d => d.Order).WithMany(p => p.Discountusagehistories)
                .HasForeignKey(d => d.Orderid)
                .HasConstraintName("fk_discountusagehistory_order_id");
        });

        modelBuilder.Entity<Download>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("download_pkey");

            entity.ToTable("download");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Contenttype)
                .HasMaxLength(4000)
                .HasColumnName("contenttype");
            entity.Property(e => e.Downloadbinary).HasColumnName("downloadbinary");
            entity.Property(e => e.Downloadguid).HasColumnName("downloadguid");
            entity.Property(e => e.Downloadurl)
                .HasMaxLength(4000)
                .HasColumnName("downloadurl");
            entity.Property(e => e.Extension)
                .HasMaxLength(4000)
                .HasColumnName("extension");
            entity.Property(e => e.Filename)
                .HasMaxLength(4000)
                .HasColumnName("filename");
            entity.Property(e => e.Isnew).HasColumnName("isnew");
            entity.Property(e => e.Usedownloadurl).HasColumnName("usedownloadurl");
        });

        modelBuilder.Entity<Emailaccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("emailaccount_pkey");

            entity.ToTable("emailaccount");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayname)
                .HasMaxLength(255)
                .HasColumnName("displayname");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Enablessl).HasColumnName("enablessl");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.Usedefaultcredentials).HasColumnName("usedefaultcredentials");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Externalauthenticationrecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("externalauthenticationrecord_pkey");

            entity.ToTable("externalauthenticationrecord");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Email)
                .HasMaxLength(4000)
                .HasColumnName("email");
            entity.Property(e => e.Externaldisplayidentifier)
                .HasMaxLength(4000)
                .HasColumnName("externaldisplayidentifier");
            entity.Property(e => e.Externalidentifier)
                .HasMaxLength(4000)
                .HasColumnName("externalidentifier");
            entity.Property(e => e.Oauthaccesstoken)
                .HasMaxLength(4000)
                .HasColumnName("oauthaccesstoken");
            entity.Property(e => e.Oauthtoken)
                .HasMaxLength(4000)
                .HasColumnName("oauthtoken");
            entity.Property(e => e.Providersystemname)
                .HasMaxLength(4000)
                .HasColumnName("providersystemname");

            entity.HasOne(d => d.Customer).WithMany(p => p.Externalauthenticationrecords)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_externalauthenticationrecord_customer_id");
        });

        modelBuilder.Entity<ForumsForum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forums_forum_pkey");

            entity.ToTable("forums_forum");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Forumgroupid).HasColumnName("forumgroupid");
            entity.Property(e => e.Lastpostcustomerid).HasColumnName("lastpostcustomerid");
            entity.Property(e => e.Lastpostid).HasColumnName("lastpostid");
            entity.Property(e => e.Lastposttime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastposttime");
            entity.Property(e => e.Lasttopicid).HasColumnName("lasttopicid");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Numposts).HasColumnName("numposts");
            entity.Property(e => e.Numtopics).HasColumnName("numtopics");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");

            entity.HasOne(d => d.Forumgroup).WithMany(p => p.ForumsForums)
                .HasForeignKey(d => d.Forumgroupid)
                .HasConstraintName("fk_forums_forum_forums_group_id");
        });

        modelBuilder.Entity<ForumsGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forums_group_pkey");

            entity.ToTable("forums_group");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");
        });

        modelBuilder.Entity<ForumsPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forums_post_pkey");

            entity.ToTable("forums_post");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(100)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Text)
                .HasMaxLength(4000)
                .HasColumnName("text");
            entity.Property(e => e.Topicid).HasColumnName("topicid");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");
            entity.Property(e => e.Votecount).HasColumnName("votecount");

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsPosts)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_forums_post_customer_id");

            entity.HasOne(d => d.Topic).WithMany(p => p.ForumsPosts)
                .HasForeignKey(d => d.Topicid)
                .HasConstraintName("fk_forums_post_forums_topic_id");
        });

        modelBuilder.Entity<ForumsPostvote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forums_postvote_pkey");

            entity.ToTable("forums_postvote");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Forumpostid).HasColumnName("forumpostid");
            entity.Property(e => e.Isup).HasColumnName("isup");

            entity.HasOne(d => d.Forumpost).WithMany(p => p.ForumsPostvotes)
                .HasForeignKey(d => d.Forumpostid)
                .HasConstraintName("fk_forums_postvote_forums_post_id");
        });

        modelBuilder.Entity<ForumsPrivatemessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forums_privatemessage_pkey");

            entity.ToTable("forums_privatemessage");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Fromcustomerid).HasColumnName("fromcustomerid");
            entity.Property(e => e.Isdeletedbyauthor).HasColumnName("isdeletedbyauthor");
            entity.Property(e => e.Isdeletedbyrecipient).HasColumnName("isdeletedbyrecipient");
            entity.Property(e => e.Isread).HasColumnName("isread");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Subject)
                .HasMaxLength(450)
                .HasColumnName("subject");
            entity.Property(e => e.Text)
                .HasMaxLength(4000)
                .HasColumnName("text");
            entity.Property(e => e.Tocustomerid).HasColumnName("tocustomerid");

            entity.HasOne(d => d.Fromcustomer).WithMany(p => p.ForumsPrivatemessageFromcustomers)
                .HasForeignKey(d => d.Fromcustomerid)
                .HasConstraintName("fk_forums_privatemessage_customer_id");

            entity.HasOne(d => d.Tocustomer).WithMany(p => p.ForumsPrivatemessageTocustomers)
                .HasForeignKey(d => d.Tocustomerid)
                .HasConstraintName("fk_forums_privatemessage_tocustomer_id");
        });

        modelBuilder.Entity<ForumsSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forums_subscription_pkey");

            entity.ToTable("forums_subscription");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Forumid).HasColumnName("forumid");
            entity.Property(e => e.Subscriptionguid).HasColumnName("subscriptionguid");
            entity.Property(e => e.Topicid).HasColumnName("topicid");

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsSubscriptions)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_forums_subscription_customer_id");
        });

        modelBuilder.Entity<ForumsTopic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forums_topic_pkey");

            entity.ToTable("forums_topic");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Forumid).HasColumnName("forumid");
            entity.Property(e => e.Lastpostcustomerid).HasColumnName("lastpostcustomerid");
            entity.Property(e => e.Lastpostid).HasColumnName("lastpostid");
            entity.Property(e => e.Lastposttime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastposttime");
            entity.Property(e => e.Numposts).HasColumnName("numposts");
            entity.Property(e => e.Subject)
                .HasMaxLength(450)
                .HasColumnName("subject");
            entity.Property(e => e.Topictypeid).HasColumnName("topictypeid");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");
            entity.Property(e => e.Views).HasColumnName("views");

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsTopics)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_forums_topic_customer_id");

            entity.HasOne(d => d.Forum).WithMany(p => p.ForumsTopics)
                .HasForeignKey(d => d.Forumid)
                .HasConstraintName("fk_forums_topic_forums_forum_id");
        });

        modelBuilder.Entity<Genericattribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genericattribute_pkey");

            entity.ToTable("genericattribute");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Entityid).HasColumnName("entityid");
            entity.Property(e => e.Keygroup)
                .HasMaxLength(400)
                .HasColumnName("keygroup");
            entity.Property(e => e.Keyname)
                .HasMaxLength(400)
                .HasColumnName("keyname");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Value)
                .HasMaxLength(4000)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Giftcard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("giftcard_pkey");

            entity.ToTable("giftcard");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 4)
                .HasColumnName("amount");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Giftcardcouponcode)
                .HasMaxLength(4000)
                .HasColumnName("giftcardcouponcode");
            entity.Property(e => e.Giftcardtypeid).HasColumnName("giftcardtypeid");
            entity.Property(e => e.Isgiftcardactivated).HasColumnName("isgiftcardactivated");
            entity.Property(e => e.Isrecipientnotified).HasColumnName("isrecipientnotified");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasColumnName("message");
            entity.Property(e => e.Purchasedwithorderitemid).HasColumnName("purchasedwithorderitemid");
            entity.Property(e => e.Recipientemail)
                .HasMaxLength(4000)
                .HasColumnName("recipientemail");
            entity.Property(e => e.Recipientname)
                .HasMaxLength(4000)
                .HasColumnName("recipientname");
            entity.Property(e => e.Senderemail)
                .HasMaxLength(4000)
                .HasColumnName("senderemail");
            entity.Property(e => e.Sendername)
                .HasMaxLength(4000)
                .HasColumnName("sendername");

            entity.HasOne(d => d.Purchasedwithorderitem).WithMany(p => p.Giftcards)
                .HasForeignKey(d => d.Purchasedwithorderitemid)
                .HasConstraintName("fk_giftcard_orderitem_id");
        });

        modelBuilder.Entity<Giftcardusagehistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("giftcardusagehistory_pkey");

            entity.ToTable("giftcardusagehistory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Giftcardid).HasColumnName("giftcardid");
            entity.Property(e => e.Usedvalue)
                .HasPrecision(18, 4)
                .HasColumnName("usedvalue");
            entity.Property(e => e.Usedwithorderid).HasColumnName("usedwithorderid");

            entity.HasOne(d => d.Giftcard).WithMany(p => p.Giftcardusagehistories)
                .HasForeignKey(d => d.Giftcardid)
                .HasConstraintName("fk_giftcardusagehistory_giftcard_id");

            entity.HasOne(d => d.Usedwithorder).WithMany(p => p.Giftcardusagehistories)
                .HasForeignKey(d => d.Usedwithorderid)
                .HasConstraintName("fk_giftcardusagehistory_order_id");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("language_pkey");

            entity.ToTable("language");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Defaultcurrencyid).HasColumnName("defaultcurrencyid");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Flagimagefilename)
                .HasMaxLength(50)
                .HasColumnName("flagimagefilename");
            entity.Property(e => e.Languageculture)
                .HasMaxLength(20)
                .HasColumnName("languageculture");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Rtl).HasColumnName("rtl");
            entity.Property(e => e.Uniqueseocode)
                .HasMaxLength(2)
                .HasColumnName("uniqueseocode");
        });

        modelBuilder.Entity<Localestringresource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("localestringresource_pkey");

            entity.ToTable("localestringresource");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Languageid).HasColumnName("languageid");
            entity.Property(e => e.Resourcename)
                .HasMaxLength(200)
                .HasColumnName("resourcename");
            entity.Property(e => e.Resourcevalue)
                .HasMaxLength(4000)
                .HasColumnName("resourcevalue");

            entity.HasOne(d => d.Language).WithMany(p => p.Localestringresources)
                .HasForeignKey(d => d.Languageid)
                .HasConstraintName("fk_localestringresource_language_id");
        });

        modelBuilder.Entity<Localizedproperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("localizedproperty_pkey");

            entity.ToTable("localizedproperty");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Entityid).HasColumnName("entityid");
            entity.Property(e => e.Languageid).HasColumnName("languageid");
            entity.Property(e => e.Localekey)
                .HasMaxLength(400)
                .HasColumnName("localekey");
            entity.Property(e => e.Localekeygroup)
                .HasMaxLength(400)
                .HasColumnName("localekeygroup");
            entity.Property(e => e.Localevalue)
                .HasMaxLength(4000)
                .HasColumnName("localevalue");

            entity.HasOne(d => d.Language).WithMany(p => p.Localizedproperties)
                .HasForeignKey(d => d.Languageid)
                .HasConstraintName("fk_localizedproperty_language_id");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("log_pkey");

            entity.ToTable("log");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Fullmessage)
                .HasMaxLength(4000)
                .HasColumnName("fullmessage");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(200)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Loglevelid).HasColumnName("loglevelid");
            entity.Property(e => e.Pageurl)
                .HasMaxLength(4000)
                .HasColumnName("pageurl");
            entity.Property(e => e.Referrerurl)
                .HasMaxLength(4000)
                .HasColumnName("referrerurl");
            entity.Property(e => e.Shortmessage)
                .HasMaxLength(4000)
                .HasColumnName("shortmessage");

            entity.HasOne(d => d.Customer).WithMany(p => p.Logs)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_log_customer_id");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufacturer_pkey");

            entity.ToTable("manufacturer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Allowcustomerstoselectpagesize).HasColumnName("allowcustomerstoselectpagesize");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Manufacturertemplateid).HasColumnName("manufacturertemplateid");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(4000)
                .HasColumnName("metadescription");
            entity.Property(e => e.Metakeywords)
                .HasMaxLength(400)
                .HasColumnName("metakeywords");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(400)
                .HasColumnName("metatitle");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Pagesize).HasColumnName("pagesize");
            entity.Property(e => e.Pagesizeoptions)
                .HasMaxLength(200)
                .HasColumnName("pagesizeoptions");
            entity.Property(e => e.Pictureid).HasColumnName("pictureid");
            entity.Property(e => e.Priceranges)
                .HasMaxLength(400)
                .HasColumnName("priceranges");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Subjecttoacl).HasColumnName("subjecttoacl");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");
        });

        modelBuilder.Entity<Manufacturertemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufacturertemplate_pkey");

            entity.ToTable("manufacturertemplate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Viewpath)
                .HasMaxLength(400)
                .HasColumnName("viewpath");
        });

        modelBuilder.Entity<Measuredimension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("measuredimension_pkey");

            entity.ToTable("measuredimension");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Ratio)
                .HasPrecision(18, 8)
                .HasColumnName("ratio");
            entity.Property(e => e.Systemkeyword)
                .HasMaxLength(100)
                .HasColumnName("systemkeyword");
        });

        modelBuilder.Entity<Measureweight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("measureweight_pkey");

            entity.ToTable("measureweight");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Ratio)
                .HasPrecision(18, 8)
                .HasColumnName("ratio");
            entity.Property(e => e.Systemkeyword)
                .HasMaxLength(100)
                .HasColumnName("systemkeyword");
        });

        modelBuilder.Entity<Messagetemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("messagetemplate_pkey");

            entity.ToTable("messagetemplate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attacheddownloadid).HasColumnName("attacheddownloadid");
            entity.Property(e => e.Bccemailaddresses)
                .HasMaxLength(200)
                .HasColumnName("bccemailaddresses");
            entity.Property(e => e.Body)
                .HasMaxLength(4000)
                .HasColumnName("body");
            entity.Property(e => e.Delaybeforesend).HasColumnName("delaybeforesend");
            entity.Property(e => e.Delayperiodid).HasColumnName("delayperiodid");
            entity.Property(e => e.Emailaccountid).HasColumnName("emailaccountid");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Subject)
                .HasMaxLength(1000)
                .HasColumnName("subject");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("news_pkey");

            entity.ToTable("news");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Allowcomments).HasColumnName("allowcomments");
            entity.Property(e => e.Commentcount).HasColumnName("commentcount");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Enddateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("enddateutc");
            entity.Property(e => e.Fullnews)
                .HasMaxLength(4000)
                .HasColumnName("fullnews");
            entity.Property(e => e.Languageid).HasColumnName("languageid");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(4000)
                .HasColumnName("metadescription");
            entity.Property(e => e.Metakeywords)
                .HasMaxLength(400)
                .HasColumnName("metakeywords");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(400)
                .HasColumnName("metatitle");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Short)
                .HasMaxLength(4000)
                .HasColumnName("short");
            entity.Property(e => e.Startdateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("startdateutc");
            entity.Property(e => e.Title)
                .HasMaxLength(4000)
                .HasColumnName("title");

            entity.HasOne(d => d.Language).WithMany(p => p.News)
                .HasForeignKey(d => d.Languageid)
                .HasConstraintName("fk_news_language_id");
        });

        modelBuilder.Entity<Newscomment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("newscomment_pkey");

            entity.ToTable("newscomment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Commenttext)
                .HasMaxLength(4000)
                .HasColumnName("commenttext");
            entity.Property(e => e.Commenttitle)
                .HasMaxLength(4000)
                .HasColumnName("commenttitle");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Newsitemid).HasColumnName("newsitemid");

            entity.HasOne(d => d.Customer).WithMany(p => p.Newscomments)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_newscomment_customer_id");

            entity.HasOne(d => d.Newsitem).WithMany(p => p.Newscomments)
                .HasForeignKey(d => d.Newsitemid)
                .HasConstraintName("fk_newscomment_news_id");
        });

        modelBuilder.Entity<Newslettersubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("newslettersubscription_pkey");

            entity.ToTable("newslettersubscription");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Newslettersubscriptionguid).HasColumnName("newslettersubscriptionguid");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Order_pkey");

            entity.ToTable("Order");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Affiliateid).HasColumnName("affiliateid");
            entity.Property(e => e.Allowstoringcreditcardnumber).HasColumnName("allowstoringcreditcardnumber");
            entity.Property(e => e.Authorizationtransactioncode)
                .HasMaxLength(4000)
                .HasColumnName("authorizationtransactioncode");
            entity.Property(e => e.Authorizationtransactionid)
                .HasMaxLength(4000)
                .HasColumnName("authorizationtransactionid");
            entity.Property(e => e.Authorizationtransactionresult)
                .HasMaxLength(4000)
                .HasColumnName("authorizationtransactionresult");
            entity.Property(e => e.Billingaddressid).HasColumnName("billingaddressid");
            entity.Property(e => e.Capturetransactionid)
                .HasMaxLength(4000)
                .HasColumnName("capturetransactionid");
            entity.Property(e => e.Capturetransactionresult)
                .HasMaxLength(4000)
                .HasColumnName("capturetransactionresult");
            entity.Property(e => e.Cardcvv2)
                .HasMaxLength(4000)
                .HasColumnName("cardcvv2");
            entity.Property(e => e.Cardexpirationmonth)
                .HasMaxLength(4000)
                .HasColumnName("cardexpirationmonth");
            entity.Property(e => e.Cardexpirationyear)
                .HasMaxLength(4000)
                .HasColumnName("cardexpirationyear");
            entity.Property(e => e.Cardname)
                .HasMaxLength(4000)
                .HasColumnName("cardname");
            entity.Property(e => e.Cardnumber)
                .HasMaxLength(4000)
                .HasColumnName("cardnumber");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(4000)
                .HasColumnName("cardtype");
            entity.Property(e => e.Checkoutattributedescription)
                .HasMaxLength(4000)
                .HasColumnName("checkoutattributedescription");
            entity.Property(e => e.Checkoutattributesxml)
                .HasMaxLength(4000)
                .HasColumnName("checkoutattributesxml");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Currencyrate)
                .HasPrecision(18, 8)
                .HasColumnName("currencyrate");
            entity.Property(e => e.Customercurrencycode)
                .HasMaxLength(4000)
                .HasColumnName("customercurrencycode");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Customerip)
                .HasMaxLength(4000)
                .HasColumnName("customerip");
            entity.Property(e => e.Customerlanguageid).HasColumnName("customerlanguageid");
            entity.Property(e => e.Customertaxdisplaytypeid).HasColumnName("customertaxdisplaytypeid");
            entity.Property(e => e.Customvaluesxml)
                .HasMaxLength(4000)
                .HasColumnName("customvaluesxml");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Maskedcreditcardnumber)
                .HasMaxLength(4000)
                .HasColumnName("maskedcreditcardnumber");
            entity.Property(e => e.Orderdiscount)
                .HasPrecision(18, 4)
                .HasColumnName("orderdiscount");
            entity.Property(e => e.Orderguid).HasColumnName("orderguid");
            entity.Property(e => e.Ordershippingexcltax)
                .HasPrecision(18, 4)
                .HasColumnName("ordershippingexcltax");
            entity.Property(e => e.Ordershippingincltax)
                .HasPrecision(18, 4)
                .HasColumnName("ordershippingincltax");
            entity.Property(e => e.Orderstatusid).HasColumnName("orderstatusid");
            entity.Property(e => e.Ordersubtotaldiscountexcltax)
                .HasPrecision(18, 4)
                .HasColumnName("ordersubtotaldiscountexcltax");
            entity.Property(e => e.Ordersubtotaldiscountincltax)
                .HasPrecision(18, 4)
                .HasColumnName("ordersubtotaldiscountincltax");
            entity.Property(e => e.Ordersubtotalexcltax)
                .HasPrecision(18, 4)
                .HasColumnName("ordersubtotalexcltax");
            entity.Property(e => e.Ordersubtotalincltax)
                .HasPrecision(18, 4)
                .HasColumnName("ordersubtotalincltax");
            entity.Property(e => e.Ordertax)
                .HasPrecision(18, 4)
                .HasColumnName("ordertax");
            entity.Property(e => e.Ordertotal)
                .HasPrecision(18, 4)
                .HasColumnName("ordertotal");
            entity.Property(e => e.Paiddateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("paiddateutc");
            entity.Property(e => e.Paymentmethodadditionalfeeexcltax)
                .HasPrecision(18, 4)
                .HasColumnName("paymentmethodadditionalfeeexcltax");
            entity.Property(e => e.Paymentmethodadditionalfeeincltax)
                .HasPrecision(18, 4)
                .HasColumnName("paymentmethodadditionalfeeincltax");
            entity.Property(e => e.Paymentmethodsystemname)
                .HasMaxLength(4000)
                .HasColumnName("paymentmethodsystemname");
            entity.Property(e => e.Paymentstatusid).HasColumnName("paymentstatusid");
            entity.Property(e => e.Pickupaddressid).HasColumnName("pickupaddressid");
            entity.Property(e => e.Pickupinstore).HasColumnName("pickupinstore");
            entity.Property(e => e.Refundedamount)
                .HasPrecision(18, 4)
                .HasColumnName("refundedamount");
            entity.Property(e => e.Rewardpointswereadded).HasColumnName("rewardpointswereadded");
            entity.Property(e => e.Shippingaddressid).HasColumnName("shippingaddressid");
            entity.Property(e => e.Shippingmethod)
                .HasMaxLength(4000)
                .HasColumnName("shippingmethod");
            entity.Property(e => e.Shippingratecomputationmethodsystemname)
                .HasMaxLength(4000)
                .HasColumnName("shippingratecomputationmethodsystemname");
            entity.Property(e => e.Shippingstatusid).HasColumnName("shippingstatusid");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Subscriptiontransactionid)
                .HasMaxLength(4000)
                .HasColumnName("subscriptiontransactionid");
            entity.Property(e => e.Taxrates)
                .HasMaxLength(4000)
                .HasColumnName("taxrates");
            entity.Property(e => e.Vatnumber)
                .HasMaxLength(4000)
                .HasColumnName("vatnumber");

            entity.HasOne(d => d.Billingaddress).WithMany(p => p.OrderBillingaddresses)
                .HasForeignKey(d => d.Billingaddressid)
                .HasConstraintName("fk_order_address_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_order_customer_id");

            entity.HasOne(d => d.Pickupaddress).WithMany(p => p.OrderPickupaddresses)
                .HasForeignKey(d => d.Pickupaddressid)
                .HasConstraintName("fk_order_pickup_address_id");

            entity.HasOne(d => d.Shippingaddress).WithMany(p => p.OrderShippingaddresses)
                .HasForeignKey(d => d.Shippingaddressid)
                .HasConstraintName("fk_order_shipping_address_id");
        });

        modelBuilder.Entity<Orderitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orderitem_pkey");

            entity.ToTable("orderitem");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attributedescription)
                .HasMaxLength(4000)
                .HasColumnName("attributedescription");
            entity.Property(e => e.Attributesxml)
                .HasMaxLength(4000)
                .HasColumnName("attributesxml");
            entity.Property(e => e.Discountamountexcltax)
                .HasPrecision(18, 4)
                .HasColumnName("discountamountexcltax");
            entity.Property(e => e.Discountamountincltax)
                .HasPrecision(18, 4)
                .HasColumnName("discountamountincltax");
            entity.Property(e => e.Downloadcount).HasColumnName("downloadcount");
            entity.Property(e => e.Isdownloadactivated).HasColumnName("isdownloadactivated");
            entity.Property(e => e.Itemweight)
                .HasPrecision(18, 4)
                .HasColumnName("itemweight");
            entity.Property(e => e.Licensedownloadid).HasColumnName("licensedownloadid");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Orderitemguid).HasColumnName("orderitemguid");
            entity.Property(e => e.Originalproductcost)
                .HasPrecision(18, 4)
                .HasColumnName("originalproductcost");
            entity.Property(e => e.Priceexcltax)
                .HasPrecision(18, 4)
                .HasColumnName("priceexcltax");
            entity.Property(e => e.Priceincltax)
                .HasPrecision(18, 4)
                .HasColumnName("priceincltax");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rentalenddateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("rentalenddateutc");
            entity.Property(e => e.Rentalstartdateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("rentalstartdateutc");
            entity.Property(e => e.Unitpriceexcltax)
                .HasPrecision(18, 4)
                .HasColumnName("unitpriceexcltax");
            entity.Property(e => e.Unitpriceincltax)
                .HasPrecision(18, 4)
                .HasColumnName("unitpriceincltax");

            entity.HasOne(d => d.Order).WithMany(p => p.Orderitems)
                .HasForeignKey(d => d.Orderid)
                .HasConstraintName("fk_orderitem_order_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Orderitems)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_orderitem_product_id");
        });

        modelBuilder.Entity<Ordernote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ordernote_pkey");

            entity.ToTable("ordernote");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Displaytocustomer).HasColumnName("displaytocustomer");
            entity.Property(e => e.Downloadid).HasColumnName("downloadid");
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .HasColumnName("note");
            entity.Property(e => e.Orderid).HasColumnName("orderid");

            entity.HasOne(d => d.Order).WithMany(p => p.Ordernotes)
                .HasForeignKey(d => d.Orderid)
                .HasConstraintName("fk_ordernote_order_id");
        });

        modelBuilder.Entity<Permissionrecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("permissionrecord_pkey");

            entity.ToTable("permissionrecord");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
            entity.Property(e => e.Systemname)
                .HasMaxLength(255)
                .HasColumnName("systemname");
        });

        modelBuilder.Entity<PermissionrecordRoleMapping>(entity =>
        {
            entity.HasKey(e => new { e.Customerroleid, e.Permissionrecordid }).HasName("permissionrecord_role_mapping_pkey");

            entity.ToTable("permissionrecord_role_mapping");

            entity.Property(e => e.Customerroleid).HasColumnName("customerroleid");
            entity.Property(e => e.Permissionrecordid).HasColumnName("permissionrecordid");
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("picture_pkey");

            entity.ToTable("picture");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Altattribute)
                .HasMaxLength(4000)
                .HasColumnName("altattribute");
            entity.Property(e => e.Isnew).HasColumnName("isnew");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(40)
                .HasColumnName("mimetype");
            entity.Property(e => e.Picturebinary).HasColumnName("picturebinary");
            entity.Property(e => e.Seofilename)
                .HasMaxLength(300)
                .HasColumnName("seofilename");
            entity.Property(e => e.Titleattribute)
                .HasMaxLength(4000)
                .HasColumnName("titleattribute");
        });

        modelBuilder.Entity<Poll>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("poll_pkey");

            entity.ToTable("poll");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Allowgueststovote).HasColumnName("allowgueststovote");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Enddateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("enddateutc");
            entity.Property(e => e.Languageid).HasColumnName("languageid");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Showonhomepage).HasColumnName("showonhomepage");
            entity.Property(e => e.Startdateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("startdateutc");
            entity.Property(e => e.Systemkeyword)
                .HasMaxLength(4000)
                .HasColumnName("systemkeyword");

            entity.HasOne(d => d.Language).WithMany(p => p.Polls)
                .HasForeignKey(d => d.Languageid)
                .HasConstraintName("fk_poll_language_id");
        });

        modelBuilder.Entity<Pollanswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pollanswer_pkey");

            entity.ToTable("pollanswer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
            entity.Property(e => e.Numberofvotes).HasColumnName("numberofvotes");
            entity.Property(e => e.Pollid).HasColumnName("pollid");

            entity.HasOne(d => d.Poll).WithMany(p => p.Pollanswers)
                .HasForeignKey(d => d.Pollid)
                .HasConstraintName("fk_pollanswer_poll_id");
        });

        modelBuilder.Entity<Pollvotingrecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pollvotingrecord_pkey");

            entity.ToTable("pollvotingrecord");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Pollanswerid).HasColumnName("pollanswerid");

            entity.HasOne(d => d.Customer).WithMany(p => p.Pollvotingrecords)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_pollvotingrecord_customer_id");

            entity.HasOne(d => d.Pollanswer).WithMany(p => p.Pollvotingrecords)
                .HasForeignKey(d => d.Pollanswerid)
                .HasConstraintName("fk_pollvotingrecord_pollanswer_id");
        });

        modelBuilder.Entity<Predefinedproductattributevalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("predefinedproductattributevalue_pkey");

            entity.ToTable("predefinedproductattributevalue");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cost)
                .HasPrecision(18, 4)
                .HasColumnName("cost");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Ispreselected).HasColumnName("ispreselected");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Priceadjustment)
                .HasPrecision(18, 4)
                .HasColumnName("priceadjustment");
            entity.Property(e => e.Productattributeid).HasColumnName("productattributeid");
            entity.Property(e => e.Weightadjustment)
                .HasPrecision(18, 4)
                .HasColumnName("weightadjustment");

            entity.HasOne(d => d.Productattribute).WithMany(p => p.Predefinedproductattributevalues)
                .HasForeignKey(d => d.Productattributeid)
                .HasConstraintName("fk_predefinedproductattributevalue_productattribute_id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pkey");

            entity.ToTable("product");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Additionalshippingcharge)
                .HasPrecision(18, 4)
                .HasColumnName("additionalshippingcharge");
            entity.Property(e => e.Admincomment)
                .HasMaxLength(4000)
                .HasColumnName("admincomment");
            entity.Property(e => e.Allowaddingonlyexistingattributecombinations).HasColumnName("allowaddingonlyexistingattributecombinations");
            entity.Property(e => e.Allowbackinstocksubscriptions).HasColumnName("allowbackinstocksubscriptions");
            entity.Property(e => e.Allowcustomerreviews).HasColumnName("allowcustomerreviews");
            entity.Property(e => e.Allowedquantities)
                .HasMaxLength(1000)
                .HasColumnName("allowedquantities");
            entity.Property(e => e.Approvedratingsum).HasColumnName("approvedratingsum");
            entity.Property(e => e.Approvedtotalreviews).HasColumnName("approvedtotalreviews");
            entity.Property(e => e.Automaticallyaddrequiredproducts).HasColumnName("automaticallyaddrequiredproducts");
            entity.Property(e => e.Availableenddatetimeutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("availableenddatetimeutc");
            entity.Property(e => e.Availableforpreorder).HasColumnName("availableforpreorder");
            entity.Property(e => e.Availablestartdatetimeutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("availablestartdatetimeutc");
            entity.Property(e => e.Backordermodeid).HasColumnName("backordermodeid");
            entity.Property(e => e.Basepriceamount)
                .HasPrecision(18, 4)
                .HasColumnName("basepriceamount");
            entity.Property(e => e.Basepricebaseamount)
                .HasPrecision(18, 4)
                .HasColumnName("basepricebaseamount");
            entity.Property(e => e.Basepricebaseunitid).HasColumnName("basepricebaseunitid");
            entity.Property(e => e.Basepriceenabled).HasColumnName("basepriceenabled");
            entity.Property(e => e.Basepriceunitid).HasColumnName("basepriceunitid");
            entity.Property(e => e.Callforprice).HasColumnName("callforprice");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerentersprice).HasColumnName("customerentersprice");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Deliverydateid).HasColumnName("deliverydateid");
            entity.Property(e => e.Disablebuybutton).HasColumnName("disablebuybutton");
            entity.Property(e => e.Disablewishlistbutton).HasColumnName("disablewishlistbutton");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Displaystockavailability).HasColumnName("displaystockavailability");
            entity.Property(e => e.Displaystockquantity).HasColumnName("displaystockquantity");
            entity.Property(e => e.Downloadactivationtypeid).HasColumnName("downloadactivationtypeid");
            entity.Property(e => e.Downloadexpirationdays).HasColumnName("downloadexpirationdays");
            entity.Property(e => e.Downloadid).HasColumnName("downloadid");
            entity.Property(e => e.Fulldescription)
                .HasMaxLength(4000)
                .HasColumnName("fulldescription");
            entity.Property(e => e.Giftcardtypeid).HasColumnName("giftcardtypeid");
            entity.Property(e => e.Gtin)
                .HasMaxLength(400)
                .HasColumnName("gtin");
            entity.Property(e => e.Hasdiscountsapplied).HasColumnName("hasdiscountsapplied");
            entity.Property(e => e.Hassampledownload).HasColumnName("hassampledownload");
            entity.Property(e => e.Hastierprices).HasColumnName("hastierprices");
            entity.Property(e => e.Hasuseragreement).HasColumnName("hasuseragreement");
            entity.Property(e => e.Height)
                .HasPrecision(18, 4)
                .HasColumnName("height");
            entity.Property(e => e.Isdownload).HasColumnName("isdownload");
            entity.Property(e => e.Isfreeshipping).HasColumnName("isfreeshipping");
            entity.Property(e => e.Isgiftcard).HasColumnName("isgiftcard");
            entity.Property(e => e.Isrecurring).HasColumnName("isrecurring");
            entity.Property(e => e.Isrental).HasColumnName("isrental");
            entity.Property(e => e.Isshipenabled).HasColumnName("isshipenabled");
            entity.Property(e => e.Istaxexempt).HasColumnName("istaxexempt");
            entity.Property(e => e.Istelecommunicationsorbroadcastingorelectronicservices).HasColumnName("istelecommunicationsorbroadcastingorelectronicservices");
            entity.Property(e => e.Length)
                .HasPrecision(18, 4)
                .HasColumnName("length");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Lowstockactivityid).HasColumnName("lowstockactivityid");
            entity.Property(e => e.Manageinventorymethodid).HasColumnName("manageinventorymethodid");
            entity.Property(e => e.Manufacturerpartnumber)
                .HasMaxLength(400)
                .HasColumnName("manufacturerpartnumber");
            entity.Property(e => e.Markasnew).HasColumnName("markasnew");
            entity.Property(e => e.Markasnewenddatetimeutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("markasnewenddatetimeutc");
            entity.Property(e => e.Markasnewstartdatetimeutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("markasnewstartdatetimeutc");
            entity.Property(e => e.Maximumcustomerenteredprice)
                .HasPrecision(18, 4)
                .HasColumnName("maximumcustomerenteredprice");
            entity.Property(e => e.Maxnumberofdownloads).HasColumnName("maxnumberofdownloads");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(4000)
                .HasColumnName("metadescription");
            entity.Property(e => e.Metakeywords)
                .HasMaxLength(400)
                .HasColumnName("metakeywords");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(400)
                .HasColumnName("metatitle");
            entity.Property(e => e.Minimumcustomerenteredprice)
                .HasPrecision(18, 4)
                .HasColumnName("minimumcustomerenteredprice");
            entity.Property(e => e.Minstockquantity).HasColumnName("minstockquantity");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Notapprovedratingsum).HasColumnName("notapprovedratingsum");
            entity.Property(e => e.Notapprovedtotalreviews).HasColumnName("notapprovedtotalreviews");
            entity.Property(e => e.Notifyadminforquantitybelow).HasColumnName("notifyadminforquantitybelow");
            entity.Property(e => e.Notreturnable).HasColumnName("notreturnable");
            entity.Property(e => e.Oldprice)
                .HasPrecision(18, 4)
                .HasColumnName("oldprice");
            entity.Property(e => e.Ordermaximumquantity).HasColumnName("ordermaximumquantity");
            entity.Property(e => e.Orderminimumquantity).HasColumnName("orderminimumquantity");
            entity.Property(e => e.Overriddengiftcardamount)
                .HasPrecision(18, 2)
                .HasColumnName("overriddengiftcardamount");
            entity.Property(e => e.Parentgroupedproductid).HasColumnName("parentgroupedproductid");
            entity.Property(e => e.Preorderavailabilitystartdatetimeutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("preorderavailabilitystartdatetimeutc");
            entity.Property(e => e.Price)
                .HasPrecision(18, 4)
                .HasColumnName("price");
            entity.Property(e => e.Productcost)
                .HasPrecision(18, 4)
                .HasColumnName("productcost");
            entity.Property(e => e.Producttemplateid).HasColumnName("producttemplateid");
            entity.Property(e => e.Producttypeid).HasColumnName("producttypeid");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Recurringcyclelength).HasColumnName("recurringcyclelength");
            entity.Property(e => e.Recurringcycleperiodid).HasColumnName("recurringcycleperiodid");
            entity.Property(e => e.Recurringtotalcycles).HasColumnName("recurringtotalcycles");
            entity.Property(e => e.Rentalpricelength).HasColumnName("rentalpricelength");
            entity.Property(e => e.Rentalpriceperiodid).HasColumnName("rentalpriceperiodid");
            entity.Property(e => e.Requiredproductids)
                .HasMaxLength(1000)
                .HasColumnName("requiredproductids");
            entity.Property(e => e.Requireotherproducts).HasColumnName("requireotherproducts");
            entity.Property(e => e.Sampledownloadid).HasColumnName("sampledownloadid");
            entity.Property(e => e.Shipseparately).HasColumnName("shipseparately");
            entity.Property(e => e.Shortdescription)
                .HasMaxLength(4000)
                .HasColumnName("shortdescription");
            entity.Property(e => e.Showonhomepage).HasColumnName("showonhomepage");
            entity.Property(e => e.Sku)
                .HasMaxLength(400)
                .HasColumnName("sku");
            entity.Property(e => e.Specialprice)
                .HasPrecision(18, 4)
                .HasColumnName("specialprice");
            entity.Property(e => e.Specialpriceenddatetimeutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("specialpriceenddatetimeutc");
            entity.Property(e => e.Specialpricestartdatetimeutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("specialpricestartdatetimeutc");
            entity.Property(e => e.Stockquantity).HasColumnName("stockquantity");
            entity.Property(e => e.Subjecttoacl).HasColumnName("subjecttoacl");
            entity.Property(e => e.Taxcategoryid).HasColumnName("taxcategoryid");
            entity.Property(e => e.Unlimiteddownloads).HasColumnName("unlimiteddownloads");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");
            entity.Property(e => e.Usemultiplewarehouses).HasColumnName("usemultiplewarehouses");
            entity.Property(e => e.Useragreementtext)
                .HasMaxLength(4000)
                .HasColumnName("useragreementtext");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Visibleindividually).HasColumnName("visibleindividually");
            entity.Property(e => e.Warehouseid).HasColumnName("warehouseid");
            entity.Property(e => e.Weight)
                .HasPrecision(18, 4)
                .HasColumnName("weight");
            entity.Property(e => e.Width)
                .HasPrecision(18, 4)
                .HasColumnName("width");
        });

        modelBuilder.Entity<ProductCategoryMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_category_mapping_pkey");

            entity.ToTable("product_category_mapping");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Isfeaturedproduct).HasColumnName("isfeaturedproduct");
            entity.Property(e => e.Productid).HasColumnName("productid");

            entity.HasOne(d => d.Category).WithMany(p => p.ProductCategoryMappings)
                .HasForeignKey(d => d.Categoryid)
                .HasConstraintName("fk_product_category_mapping_category_id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCategoryMappings)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_product_category_mapping_product_id");
        });

        modelBuilder.Entity<ProductManufacturerMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_manufacturer_mapping_pkey");

            entity.ToTable("product_manufacturer_mapping");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Isfeaturedproduct).HasColumnName("isfeaturedproduct");
            entity.Property(e => e.Manufacturerid).HasColumnName("manufacturerid");
            entity.Property(e => e.Productid).HasColumnName("productid");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.ProductManufacturerMappings)
                .HasForeignKey(d => d.Manufacturerid)
                .HasConstraintName("fk_product_manufacturer_mapping_manufacturer_id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductManufacturerMappings)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_product_manufacturer_mapping_product_id");
        });

        modelBuilder.Entity<ProductPictureMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_picture_mapping_pkey");

            entity.ToTable("product_picture_mapping");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Pictureid).HasColumnName("pictureid");
            entity.Property(e => e.Productid).HasColumnName("productid");

            entity.HasOne(d => d.Picture).WithMany(p => p.ProductPictureMappings)
                .HasForeignKey(d => d.Pictureid)
                .HasConstraintName("fk_product_picture_mapping_picture_id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductPictureMappings)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_product_picture_mapping_product_id");
        });

        modelBuilder.Entity<ProductProductattributeMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_productattribute_mapping_pkey");

            entity.ToTable("product_productattribute_mapping");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attributecontroltypeid).HasColumnName("attributecontroltypeid");
            entity.Property(e => e.Conditionattributexml)
                .HasMaxLength(4000)
                .HasColumnName("conditionattributexml");
            entity.Property(e => e.Defaultvalue)
                .HasMaxLength(4000)
                .HasColumnName("defaultvalue");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Isrequired).HasColumnName("isrequired");
            entity.Property(e => e.Productattributeid).HasColumnName("productattributeid");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Textprompt)
                .HasMaxLength(4000)
                .HasColumnName("textprompt");
            entity.Property(e => e.Validationfileallowedextensions)
                .HasMaxLength(4000)
                .HasColumnName("validationfileallowedextensions");
            entity.Property(e => e.Validationfilemaximumsize).HasColumnName("validationfilemaximumsize");
            entity.Property(e => e.Validationmaxlength).HasColumnName("validationmaxlength");
            entity.Property(e => e.Validationminlength).HasColumnName("validationminlength");

            entity.HasOne(d => d.Productattribute).WithMany(p => p.ProductProductattributeMappings)
                .HasForeignKey(d => d.Productattributeid)
                .HasConstraintName("fk_product_productattribute_mapping_productattribute_id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductProductattributeMappings)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_product_productattribute_mapping_product_id");
        });

        modelBuilder.Entity<ProductProducttagMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_producttag_mapping_pkey");

            entity.ToTable("product_producttag_mapping");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProducttagId).HasColumnName("producttag_id");
        });

        modelBuilder.Entity<ProductSpecificationattributeMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_specificationattribute_mapping_pkey");

            entity.ToTable("product_specificationattribute_mapping");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Allowfiltering).HasColumnName("allowfiltering");
            entity.Property(e => e.Attributetypeid).HasColumnName("attributetypeid");
            entity.Property(e => e.Customvalue)
                .HasMaxLength(4000)
                .HasColumnName("customvalue");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Showonproductpage).HasColumnName("showonproductpage");
            entity.Property(e => e.Specificationattributeoptionid).HasColumnName("specificationattributeoptionid");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSpecificationattributeMappings)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_product_specificationattribute_mapping_product_id");

            entity.HasOne(d => d.Specificationattributeoption).WithMany(p => p.ProductSpecificationattributeMappings)
                .HasForeignKey(d => d.Specificationattributeoptionid)
                .HasConstraintName("fk_product_specificationattribute_mapping_specificationattribut");
        });

        modelBuilder.Entity<Productattribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("productattribute_pkey");

            entity.ToTable("productattribute");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Productattributecombination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("productattributecombination_pkey");

            entity.ToTable("productattributecombination");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Allowoutofstockorders).HasColumnName("allowoutofstockorders");
            entity.Property(e => e.Attributesxml)
                .HasMaxLength(4000)
                .HasColumnName("attributesxml");
            entity.Property(e => e.Gtin)
                .HasMaxLength(400)
                .HasColumnName("gtin");
            entity.Property(e => e.Manufacturerpartnumber)
                .HasMaxLength(400)
                .HasColumnName("manufacturerpartnumber");
            entity.Property(e => e.Notifyadminforquantitybelow).HasColumnName("notifyadminforquantitybelow");
            entity.Property(e => e.Overriddenprice)
                .HasPrecision(18, 4)
                .HasColumnName("overriddenprice");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Sku)
                .HasMaxLength(400)
                .HasColumnName("sku");
            entity.Property(e => e.Stockquantity).HasColumnName("stockquantity");

            entity.HasOne(d => d.Product).WithMany(p => p.Productattributecombinations)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_productattributecombination_product_id");
        });

        modelBuilder.Entity<Productattributevalue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("productattributevalue_pkey");

            entity.ToTable("productattributevalue");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Associatedproductid).HasColumnName("associatedproductid");
            entity.Property(e => e.Attributevaluetypeid).HasColumnName("attributevaluetypeid");
            entity.Property(e => e.Colorsquaresrgb)
                .HasMaxLength(100)
                .HasColumnName("colorsquaresrgb");
            entity.Property(e => e.Cost)
                .HasPrecision(18, 4)
                .HasColumnName("cost");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Imagesquarespictureid).HasColumnName("imagesquarespictureid");
            entity.Property(e => e.Ispreselected).HasColumnName("ispreselected");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Pictureid).HasColumnName("pictureid");
            entity.Property(e => e.Priceadjustment)
                .HasPrecision(18, 4)
                .HasColumnName("priceadjustment");
            entity.Property(e => e.Productattributemappingid).HasColumnName("productattributemappingid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Weightadjustment)
                .HasPrecision(18, 4)
                .HasColumnName("weightadjustment");

            entity.HasOne(d => d.Productattributemapping).WithMany(p => p.Productattributevalues)
                .HasForeignKey(d => d.Productattributemappingid)
                .HasConstraintName("fk_productattributevalue_product_productattribute_mapping_id");
        });

        modelBuilder.Entity<Productreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("productreview_pkey");

            entity.ToTable("productreview");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Helpfulnototal).HasColumnName("helpfulnototal");
            entity.Property(e => e.Helpfulyestotal).HasColumnName("helpfulyestotal");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Reviewtext)
                .HasMaxLength(4000)
                .HasColumnName("reviewtext");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Title)
                .HasMaxLength(4000)
                .HasColumnName("title");

            entity.HasOne(d => d.Customer).WithMany(p => p.Productreviews)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_productreview_customer_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Productreviews)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_productreview_product_id");

            entity.HasOne(d => d.Store).WithMany(p => p.Productreviews)
                .HasForeignKey(d => d.Storeid)
                .HasConstraintName("fk_productreview_store_id");
        });

        modelBuilder.Entity<Productreviewhelpfulness>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("productreviewhelpfulness_pkey");

            entity.ToTable("productreviewhelpfulness");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Productreviewid).HasColumnName("productreviewid");
            entity.Property(e => e.Washelpful).HasColumnName("washelpful");

            entity.HasOne(d => d.Productreview).WithMany(p => p.Productreviewhelpfulnesses)
                .HasForeignKey(d => d.Productreviewid)
                .HasConstraintName("fk_productreviewhelpfulness_productreview_id");
        });

        modelBuilder.Entity<Producttag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("producttag_pkey");

            entity.ToTable("producttag");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Producttemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("producttemplate_pkey");

            entity.ToTable("producttemplate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Viewpath)
                .HasMaxLength(400)
                .HasColumnName("viewpath");
        });

        modelBuilder.Entity<Productwarehouseinventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("productwarehouseinventory_pkey");

            entity.ToTable("productwarehouseinventory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Reservedquantity).HasColumnName("reservedquantity");
            entity.Property(e => e.Stockquantity).HasColumnName("stockquantity");
            entity.Property(e => e.Warehouseid).HasColumnName("warehouseid");

            entity.HasOne(d => d.Product).WithMany(p => p.Productwarehouseinventories)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_productwarehouseinventory_product_id");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Productwarehouseinventories)
                .HasForeignKey(d => d.Warehouseid)
                .HasConstraintName("fk_productwarehouseinventory_warehouse_id");
        });

        modelBuilder.Entity<Queuedemail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("queuedemail_pkey");

            entity.ToTable("queuedemail");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attacheddownloadid).HasColumnName("attacheddownloadid");
            entity.Property(e => e.Attachmentfilename)
                .HasMaxLength(4000)
                .HasColumnName("attachmentfilename");
            entity.Property(e => e.Attachmentfilepath)
                .HasMaxLength(4000)
                .HasColumnName("attachmentfilepath");
            entity.Property(e => e.Bcc)
                .HasMaxLength(500)
                .HasColumnName("bcc");
            entity.Property(e => e.Body)
                .HasMaxLength(4000)
                .HasColumnName("body");
            entity.Property(e => e.Cc)
                .HasMaxLength(500)
                .HasColumnName("cc");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Dontsendbeforedateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dontsendbeforedateutc");
            entity.Property(e => e.Emailaccountid).HasColumnName("emailaccountid");
            entity.Property(e => e.Fromemail)
                .HasMaxLength(500)
                .HasColumnName("fromemail");
            entity.Property(e => e.Fromname)
                .HasMaxLength(500)
                .HasColumnName("fromname");
            entity.Property(e => e.Priorityid).HasColumnName("priorityid");
            entity.Property(e => e.Replyto)
                .HasMaxLength(500)
                .HasColumnName("replyto");
            entity.Property(e => e.Replytoname)
                .HasMaxLength(500)
                .HasColumnName("replytoname");
            entity.Property(e => e.Sentonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sentonutc");
            entity.Property(e => e.Senttries).HasColumnName("senttries");
            entity.Property(e => e.Subject)
                .HasMaxLength(1000)
                .HasColumnName("subject");
            entity.Property(e => e.Toemail)
                .HasMaxLength(500)
                .HasColumnName("toemail");
            entity.Property(e => e.Toname)
                .HasMaxLength(500)
                .HasColumnName("toname");

            entity.HasOne(d => d.Emailaccount).WithMany(p => p.Queuedemails)
                .HasForeignKey(d => d.Emailaccountid)
                .HasConstraintName("fk_queuedemail_emailaccount_id");
        });

        modelBuilder.Entity<Recurringpayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("recurringpayment_pkey");

            entity.ToTable("recurringpayment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Cyclelength).HasColumnName("cyclelength");
            entity.Property(e => e.Cycleperiodid).HasColumnName("cycleperiodid");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Initialorderid).HasColumnName("initialorderid");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Startdateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("startdateutc");
            entity.Property(e => e.Totalcycles).HasColumnName("totalcycles");

            entity.HasOne(d => d.Initialorder).WithMany(p => p.Recurringpayments)
                .HasForeignKey(d => d.Initialorderid)
                .HasConstraintName("fk_recurringpayment_order_id");
        });

        modelBuilder.Entity<Recurringpaymenthistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("recurringpaymenthistory_pkey");

            entity.ToTable("recurringpaymenthistory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Recurringpaymentid).HasColumnName("recurringpaymentid");

            entity.HasOne(d => d.Recurringpayment).WithMany(p => p.Recurringpaymenthistories)
                .HasForeignKey(d => d.Recurringpaymentid)
                .HasConstraintName("fk_recurringpaymenthistory_recurringpayment_id");
        });

        modelBuilder.Entity<Relatedproduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("relatedproduct_pkey");

            entity.ToTable("relatedproduct");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Productid1).HasColumnName("productid1");
            entity.Property(e => e.Productid2).HasColumnName("productid2");
        });

        modelBuilder.Entity<Returnrequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("returnrequest_pkey");

            entity.ToTable("returnrequest");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customercomments)
                .HasMaxLength(4000)
                .HasColumnName("customercomments");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Customnumber)
                .HasMaxLength(4000)
                .HasColumnName("customnumber");
            entity.Property(e => e.Orderitemid).HasColumnName("orderitemid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Reasonforreturn)
                .HasMaxLength(4000)
                .HasColumnName("reasonforreturn");
            entity.Property(e => e.Requestedaction)
                .HasMaxLength(4000)
                .HasColumnName("requestedaction");
            entity.Property(e => e.Returnrequeststatusid).HasColumnName("returnrequeststatusid");
            entity.Property(e => e.Staffnotes)
                .HasMaxLength(4000)
                .HasColumnName("staffnotes");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");

            entity.HasOne(d => d.Customer).WithMany(p => p.Returnrequests)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_returnrequest_customer_id");
        });

        modelBuilder.Entity<Returnrequestaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("returnrequestaction_pkey");

            entity.ToTable("returnrequestaction");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Returnrequestreason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("returnrequestreason_pkey");

            entity.ToTable("returnrequestreason");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Rewardpointshistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("rewardpointshistory_pkey");

            entity.ToTable("rewardpointshistory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasColumnName("message");
            entity.Property(e => e.Points).HasColumnName("points");
            entity.Property(e => e.Pointsbalance).HasColumnName("pointsbalance");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Usedamount)
                .HasPrecision(18, 4)
                .HasColumnName("usedamount");
            entity.Property(e => e.UsedwithorderId).HasColumnName("usedwithorder_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Rewardpointshistories)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_rewardpointshistory_customer_id");

            entity.HasOne(d => d.Usedwithorder).WithMany(p => p.Rewardpointshistories)
                .HasForeignKey(d => d.UsedwithorderId)
                .HasConstraintName("fk_rewardpointshistory_order_id");
        });

        modelBuilder.Entity<Scheduletask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("scheduletask_pkey");

            entity.ToTable("scheduletask");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Lastendutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastendutc");
            entity.Property(e => e.Laststartutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("laststartutc");
            entity.Property(e => e.Lastsuccessutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastsuccessutc");
            entity.Property(e => e.Leasedbymachinename)
                .HasMaxLength(4000)
                .HasColumnName("leasedbymachinename");
            entity.Property(e => e.Leaseduntilutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("leaseduntilutc");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
            entity.Property(e => e.Seconds).HasColumnName("seconds");
            entity.Property(e => e.Stoponerror).HasColumnName("stoponerror");
            entity.Property(e => e.Type)
                .HasMaxLength(4000)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Searchterm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("searchterm_pkey");

            entity.ToTable("searchterm");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Keyword)
                .HasMaxLength(4000)
                .HasColumnName("keyword");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("setting_pkey");

            entity.ToTable("setting");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Value)
                .HasMaxLength(2000)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shipment_pkey");

            entity.ToTable("shipment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Admincomment)
                .HasMaxLength(4000)
                .HasColumnName("admincomment");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Deliverydateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deliverydateutc");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Shippeddateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("shippeddateutc");
            entity.Property(e => e.Totalweight)
                .HasPrecision(18, 4)
                .HasColumnName("totalweight");
            entity.Property(e => e.Trackingnumber)
                .HasMaxLength(4000)
                .HasColumnName("trackingnumber");

            entity.HasOne(d => d.Order).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.Orderid)
                .HasConstraintName("fk_shipment_order_id");
        });

        modelBuilder.Entity<Shipmentitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shipmentitem_pkey");

            entity.ToTable("shipmentitem");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Orderitemid).HasColumnName("orderitemid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Shipmentid).HasColumnName("shipmentid");
            entity.Property(e => e.Warehouseid).HasColumnName("warehouseid");

            entity.HasOne(d => d.Shipment).WithMany(p => p.Shipmentitems)
                .HasForeignKey(d => d.Shipmentid)
                .HasConstraintName("fk_shipmentitem_shipment_id");
        });

        modelBuilder.Entity<Shippingmethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shippingmethod_pkey");

            entity.ToTable("shippingmethod");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Shippingmethodrestriction>(entity =>
        {
            entity.HasKey(e => new { e.CountryId, e.ShippingmethodId }).HasName("shippingmethodrestrictions_pkey");

            entity.ToTable("shippingmethodrestrictions");

            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.ShippingmethodId).HasColumnName("shippingmethod_id");
        });

        modelBuilder.Entity<Shoppingcartitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shoppingcartitem_pkey");

            entity.ToTable("shoppingcartitem");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attributesxml)
                .HasMaxLength(4000)
                .HasColumnName("attributesxml");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Customerenteredprice)
                .HasPrecision(18, 4)
                .HasColumnName("customerenteredprice");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rentalenddateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("rentalenddateutc");
            entity.Property(e => e.Rentalstartdateutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("rentalstartdateutc");
            entity.Property(e => e.Shoppingcarttypeid).HasColumnName("shoppingcarttypeid");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Updatedonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updatedonutc");

            entity.HasOne(d => d.Customer).WithMany(p => p.Shoppingcartitems)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("fk_shoppingcartitem_customer_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Shoppingcartitems)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_shoppingcartitem_product_id");
        });

        modelBuilder.Entity<Specificationattribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("specificationattribute_pkey");

            entity.ToTable("specificationattribute");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Specificationattributeoption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("specificationattributeoption_pkey");

            entity.ToTable("specificationattributeoption");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Colorsquaresrgb)
                .HasMaxLength(100)
                .HasColumnName("colorsquaresrgb");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(4000)
                .HasColumnName("name");
            entity.Property(e => e.Specificationattributeid).HasColumnName("specificationattributeid");

            entity.HasOne(d => d.Specificationattribute).WithMany(p => p.Specificationattributeoptions)
                .HasForeignKey(d => d.Specificationattributeid)
                .HasConstraintName("fk_specificationattributeoption_specificationattribute_id");
        });

        modelBuilder.Entity<Stateprovince>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stateprovince_pkey");

            entity.ToTable("stateprovince");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(100)
                .HasColumnName("abbreviation");
            entity.Property(e => e.Countryid).HasColumnName("countryid");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Published).HasColumnName("published");

            entity.HasOne(d => d.Country).WithMany(p => p.Stateprovinces)
                .HasForeignKey(d => d.Countryid)
                .HasConstraintName("fk_stateprovince_country_id");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("store_pkey");

            entity.ToTable("store");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Companyaddress)
                .HasMaxLength(1000)
                .HasColumnName("companyaddress");
            entity.Property(e => e.Companyname)
                .HasMaxLength(1000)
                .HasColumnName("companyname");
            entity.Property(e => e.Companyphonenumber)
                .HasMaxLength(1000)
                .HasColumnName("companyphonenumber");
            entity.Property(e => e.Companyvat)
                .HasMaxLength(1000)
                .HasColumnName("companyvat");
            entity.Property(e => e.Defaultlanguageid).HasColumnName("defaultlanguageid");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Hosts)
                .HasMaxLength(1000)
                .HasColumnName("hosts");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Secureurl)
                .HasMaxLength(400)
                .HasColumnName("secureurl");
            entity.Property(e => e.Sslenabled).HasColumnName("sslenabled");
            entity.Property(e => e.Url)
                .HasMaxLength(400)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Storemapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("storemapping_pkey");

            entity.ToTable("storemapping");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Entityid).HasColumnName("entityid");
            entity.Property(e => e.Entityname)
                .HasMaxLength(400)
                .HasColumnName("entityname");
            entity.Property(e => e.Storeid).HasColumnName("storeid");

            entity.HasOne(d => d.Store).WithMany(p => p.Storemappings)
                .HasForeignKey(d => d.Storeid)
                .HasConstraintName("fk_storemapping_store_id");
        });

        modelBuilder.Entity<Taxcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("taxcategory_pkey");

            entity.ToTable("taxcategory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Tierprice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tierprice_pkey");

            entity.ToTable("tierprice");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Customerroleid).HasColumnName("customerroleid");
            entity.Property(e => e.Price)
                .HasPrecision(18, 4)
                .HasColumnName("price");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Storeid).HasColumnName("storeid");

            entity.HasOne(d => d.Customerrole).WithMany(p => p.Tierprices)
                .HasForeignKey(d => d.Customerroleid)
                .HasConstraintName("fk_tierprice_customerrole_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Tierprices)
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("fk_tierprice_product_id");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("topic_pkey");

            entity.ToTable("topic");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Accessiblewhenstoreclosed).HasColumnName("accessiblewhenstoreclosed");
            entity.Property(e => e.Body)
                .HasMaxLength(4000)
                .HasColumnName("body");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Includeinfootercolumn1).HasColumnName("includeinfootercolumn1");
            entity.Property(e => e.Includeinfootercolumn2).HasColumnName("includeinfootercolumn2");
            entity.Property(e => e.Includeinfootercolumn3).HasColumnName("includeinfootercolumn3");
            entity.Property(e => e.Includeinsitemap).HasColumnName("includeinsitemap");
            entity.Property(e => e.Includeintopmenu).HasColumnName("includeintopmenu");
            entity.Property(e => e.Ispasswordprotected).HasColumnName("ispasswordprotected");
            entity.Property(e => e.Limitedtostores).HasColumnName("limitedtostores");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(4000)
                .HasColumnName("metadescription");
            entity.Property(e => e.Metakeywords)
                .HasMaxLength(4000)
                .HasColumnName("metakeywords");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(4000)
                .HasColumnName("metatitle");
            entity.Property(e => e.Password)
                .HasMaxLength(4000)
                .HasColumnName("password");
            entity.Property(e => e.Published).HasColumnName("published");
            entity.Property(e => e.Subjecttoacl).HasColumnName("subjecttoacl");
            entity.Property(e => e.Systemname)
                .HasMaxLength(4000)
                .HasColumnName("systemname");
            entity.Property(e => e.Title)
                .HasMaxLength(4000)
                .HasColumnName("title");
            entity.Property(e => e.Topictemplateid).HasColumnName("topictemplateid");
        });

        modelBuilder.Entity<Topictemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("topictemplate_pkey");

            entity.ToTable("topictemplate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Viewpath)
                .HasMaxLength(400)
                .HasColumnName("viewpath");
        });

        modelBuilder.Entity<Urlrecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("urlrecord_pkey");

            entity.ToTable("urlrecord");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Entityid).HasColumnName("entityid");
            entity.Property(e => e.Entityname)
                .HasMaxLength(400)
                .HasColumnName("entityname");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Languageid).HasColumnName("languageid");
            entity.Property(e => e.Slug)
                .HasMaxLength(400)
                .HasColumnName("slug");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vendor_pkey");

            entity.ToTable("vendor");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Admincomment)
                .HasMaxLength(4000)
                .HasColumnName("admincomment");
            entity.Property(e => e.Allowcustomerstoselectpagesize).HasColumnName("allowcustomerstoselectpagesize");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description");
            entity.Property(e => e.Displayorder).HasColumnName("displayorder");
            entity.Property(e => e.Email)
                .HasMaxLength(400)
                .HasColumnName("email");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(4000)
                .HasColumnName("metadescription");
            entity.Property(e => e.Metakeywords)
                .HasMaxLength(400)
                .HasColumnName("metakeywords");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(400)
                .HasColumnName("metatitle");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
            entity.Property(e => e.Pagesize).HasColumnName("pagesize");
            entity.Property(e => e.Pagesizeoptions)
                .HasMaxLength(200)
                .HasColumnName("pagesizeoptions");
            entity.Property(e => e.Pictureid).HasColumnName("pictureid");
        });

        modelBuilder.Entity<Vendornote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vendornote_pkey");

            entity.ToTable("vendornote");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Createdonutc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdonutc");
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .HasColumnName("note");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");

            entity.HasOne(d => d.Vendor).WithMany(p => p.Vendornotes)
                .HasForeignKey(d => d.Vendorid)
                .HasConstraintName("fk_vendornote_vendor_id");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("warehouse_pkey");

            entity.ToTable("warehouse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Addressid).HasColumnName("addressid");
            entity.Property(e => e.Admincomment)
                .HasMaxLength(4000)
                .HasColumnName("admincomment");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
