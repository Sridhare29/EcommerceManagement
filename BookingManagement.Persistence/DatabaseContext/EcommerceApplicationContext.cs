using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Management.Domain.Models;

public partial class EcommerceApplicationContext : DbContext
{
    public EcommerceApplicationContext()
    {
    }

    public EcommerceApplicationContext(DbContextOptions<EcommerceApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }

    public virtual DbSet<ProductAttributeType> ProductAttributeTypes { get; set; }

    public virtual DbSet<ProductSku> ProductSkus { get; set; }


    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Wishlist> Wishlists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EcommerceApplicationContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


   // public override Task(Guid) SaveChangesArgs(CancellationToken cancellationToken = default)
  //      {
//return base.SaveChangesAsync(cancellationToken);
  //  }
}
