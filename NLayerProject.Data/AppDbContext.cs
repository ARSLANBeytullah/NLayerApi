using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data
{
    public class AppDbContext : DbContext
    {
         

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP - KBVDE09\\SQLEXPRESS; database = NLayerProject; " +
                "integrated-security = true;");
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductsFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Bu kod bütün assembly'lerde ki(her bir katman aynı zaman da assembly olarak adlandırılır.)  
            //Tek bir satırda bütün configuration dosyalarını okur
            


            //Bu şekilde tek tek yazmak yerine üstte ki tek bir satır kodla aynı şeyi yapabiliriz.
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration);
            //modelBuilder.ApplyConfiguration(new ProductConfiguration);    
            //modelBuilder.ApplyConfiguration(new ProductFeatureConfiguration);

            base.OnModelCreating(modelBuilder);
        }
    }
}
