using AutoMapper;
using NLayerProject.Core.Dtos;
using NLayerProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Business.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap(); //ReverseMap methodu sayesin de tam tersi de geçerlidir.Yani CreatedMap<ProductDto,Product>() yapmış oluyoruz.
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>(); //Tersine ihtiyacımız yok o yüzden ReverseMap methodunu çağırmadım.
        
        }
    }
}
