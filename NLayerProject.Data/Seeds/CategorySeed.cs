using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category> //Veritabanı oluşurken içerisin de ilk oluşacak kayıtlar seed sınıflarının içerisin de tanımlanır.
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Kalemler" }, 
                new Category{ Id = 2, Name = "Kitaplar" }, 
                new Category{ Id = 3, Name="Defterler"});
        }
    }
}
