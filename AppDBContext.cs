using System;
using Microsoft.EntityFrameworkCore;
using Final_Luke_Jacob.Models;

namespace Final_Luke_Jacob.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<OurInfo> OurInfos { get; set; }
        public DbSet<Class2> Hobbies { get; set; }  //change these names to match the classes
        public DbSet<Class3> BreakfastFoods { get; set; }   //change these names to match the classes
        public DbSet<Class4> Movies { get; set; }           //change these names to match the classes
    }
}
