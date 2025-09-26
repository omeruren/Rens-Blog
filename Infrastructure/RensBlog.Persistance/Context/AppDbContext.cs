﻿using Microsoft.EntityFrameworkCore;
using RensBlog.Domain.Entities;

namespace RensBlog.Persistance.Context
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Social> Socials { get; set; }
    }
}
