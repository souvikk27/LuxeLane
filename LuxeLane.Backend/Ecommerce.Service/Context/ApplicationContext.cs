﻿using Ecommerce.Domain.Entities;
using Ecommerce.Service.Contract.Generators;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Service.Context;

public class ApplicationContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<Category> Category { get; set; }

    public virtual DbSet<OrderDetails> Orders { get; set; }

    public virtual DbSet<ShoppingCart> Cart { get; set; }

    public virtual DbSet<ShoppingSession> Session { get; set; }

    public virtual DbSet<Payment> Payment { get; set; }

    public virtual DbSet<OrderPayment> OrderPayment { get; set; }

    public DbSet<ApplicationUser> User { get; set; }

    public virtual DbSet<OAuthClient> OAuthClient { get; set; }

    public virtual DbSet<ProductCategory> ProductCategory { get; set; }

    public virtual DbSet<UserAddress> UserAddress { get; set; }

    public virtual DbSet<UserPayment> UserPayment { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.Entity<ApplicationUser>(entity =>
        {
            entity.ToTable(name: "User");
        });

        builder.Entity<IdentityRole>(entity =>
        {
            entity.ToTable(name: "Role");
        });

        builder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.ToTable("UserRoles");
        });

        builder.Entity<IdentityUserClaim<string>>(entity =>
        {
            entity.ToTable("UserClaims");
        });

        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.ToTable("UserLogins");
        });

        builder.Entity<IdentityRoleClaim<string>>(entity =>
        {
            entity.ToTable("RoleClaims");

        });

        builder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.ToTable("UserTokens");
        });

        builder.Entity<OAuthClient>()
           .HasOne(o => o.User)
           .WithMany(u => u.OAuthClient)
           .HasForeignKey(o => o.UserId)
           .IsRequired();

        builder.Entity<ProductCategory>()
        .HasKey(pc => new { pc.ProductId, pc.CategoryId });

        builder.Entity<ProductCategory>()
            .HasOne(pc => pc.Product)
            .WithMany(p => p.ProductCategories)
            .HasForeignKey(pc => pc.ProductId)
            .OnDelete(DeleteBehavior.NoAction); 

        builder.Entity<ProductCategory>()
            .HasOne(pc => pc.Category)
            .WithMany(c => c.ProductCategories)
            .HasForeignKey(pc => pc.CategoryId)
            .OnDelete(DeleteBehavior.NoAction); 

        builder.Entity<Product>()
            .HasOne(p => p.Discount)
            .WithMany()
            .HasForeignKey(p => p.DiscountId);

        builder.Entity<Product>()
            .HasOne(p => p.Inventory)
            .WithMany()
            .HasForeignKey(p => p.InventoryId);

        builder.Entity<OrderDetails>()
            .HasOne(od => od.Payment)
            .WithOne(p => p.OrderDetails)
            .HasForeignKey<OrderDetails>(od => od.PaymentId);

        builder.Entity<OrderDetails>()
            .HasOne(od => od.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(od => od.UserId)
            .HasPrincipalKey(od => od.Id);

        builder.Entity<OrderDetails>()
            .HasOne(od => od.OrderPayment)
            .WithOne(op => op.OrderDetails)
            .HasForeignKey<OrderPayment>(op => op.Orderid);

        builder.Entity<ShoppingSession>()
            .HasOne(ss => ss.User)
            .WithMany(u => u.ShoppingSessions)
            .HasForeignKey(ss => ss.UserId)
            .HasPrincipalKey(ss => ss.Id);

        builder.Entity<ApplicationUser>()
            .HasMany(u => u.ShoppingSessions)
            .WithOne(ss => ss.User)
            .HasPrincipalKey(ss => ss.Id);

        builder.Entity<CartProduct>()
        .HasKey(cp => new { cp.CartId, cp.ProductId });

        builder.Entity<CartProduct>()
            .HasOne(cp => cp.Cart)
            .WithMany(c => c.CartProducts)
            .HasForeignKey(cp => cp.CartId);

        builder.Entity<CartProduct>()
            .HasOne(cp => cp.Product)
            .WithMany(p => p.CartProducts)
            .HasForeignKey(cp => cp.ProductId);

        builder.Entity<UserAddress>()
            .HasOne(ua => ua.User)
            .WithMany(u => u.UserAddresses)
            .HasForeignKey(ua => ua.UserId)
            .HasPrincipalKey(ua => ua.Id);

        builder.Entity<UserPayment>()
        .HasKey(up => up.Id);

        builder.Entity<UserPayment>()
            .HasOne(up => up.User)
            .WithMany(u => u.UserPayments)
            .HasForeignKey(up => up.UserId)
            .HasPrincipalKey(up => up.Id);

        builder.Entity<UserPayment>()
            .HasOne(up => up.Payment)
            .WithMany(p => p.UserPayments)
            .HasForeignKey(up => up.PaymentId);
        
        builder.Entity<ProductImage>()
            .HasOne(pi => pi.Product)
            .WithMany(p => p.ProductImages)
            .HasForeignKey(pi => pi.ProductId);
    }
    
}