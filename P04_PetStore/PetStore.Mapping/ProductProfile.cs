using System;
using AutoMapper;
using PetStore.Models;
using PetStore.Models.Enumerations;
using PetStore.ServiceModels.Products.InputModels;
using PetStore.ServiceModels.Products.OutputModels;

namespace PetStore.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<AddProductInputServiceModel, Product>()
                .ForMember(to => to.ProductType,
                        opt => opt.MapFrom
                        (from => Enum.Parse(typeof(ProductType), from.ProductType)));



            this.CreateMap<Product, ListAllProductsByProductTypeServiceModel>();

            this.CreateMap<Product, ListAllProductsServiceModel>()
                .ForMember(to => to.ProductType, 
                        opt => opt.MapFrom
                        (from => from.ProductType.ToString()));

            this.CreateMap<Product, ListAllProductsByNameServiceModel>()
                .ForMember(to => to.ProductType, 
                        opt => opt.MapFrom
                        (from => from.ProductType.ToString()));


             
            this.CreateMap<EditProductInputServiceModel, Product>()
                .ForMember(to => to.ProductType, 
                        opt => opt.MapFrom
                        (from => Enum.Parse(typeof(ProductType), from.ProductType)));
        }
    }
}
