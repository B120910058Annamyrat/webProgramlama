using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using proje.Models.Entities;


namespace proje.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<User> Users { get; set ; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7VM71FC\\SQLEXPRESS;Database=PlaneVeri;Trusted_Connection=True;");
        }
    }
}
