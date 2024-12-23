using System;
using Microsoft.EntityFrameworkCore;
using SignalR.Entity.Entities;

namespace SignalR.DAL.Concrete;

public class SignalRContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=LAPTOP-0PGAT8H5\\SQLEXPRESS; initial catalog=SignalRDb; integrated security=true; TrustServerCertificate=True");
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
}
