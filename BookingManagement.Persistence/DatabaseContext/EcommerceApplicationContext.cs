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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=KANINI-LTP-814\\SQLEXPRESS;Database=EcommerceDb;User Id=sa;Password=@Codesri29;Encrypt=False;TrustServerCertificate=true");
        }
    }


    // public override Task(Guid) SaveChangesArgs(CancellationToken cancellationToken = default)
    //      {
    //return base.SaveChangesAsync(cancellationToken);
    //  }
}
