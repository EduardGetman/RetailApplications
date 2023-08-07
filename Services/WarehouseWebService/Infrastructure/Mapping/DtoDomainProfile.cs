using AutoMapper;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Mapping
{
    public class DtoDomainProfile : Profile
    {
        public DtoDomainProfile()
        {
            CreateMap<Product, Dto.ModelDto.Product>().ReverseMap();
            CreateMap<Warehouse, Dto.ModelDto.Warehouse>().ReverseMap();
            CreateMap<Shipment, Dto.ModelDto.Shipment>().ReverseMap();
            CreateMap<Supplier, Dto.ModelDto.Supplier>().ReverseMap();
            CreateMap<ShipmentDestination,Dto.ModelDto.ShipmentDestination>().ReverseMap();
            CreateMap<ProductStock,Dto.ModelDto.ProductStock>().ReverseMap();
            CreateMap<Delivery, Dto.ModelDto.Delivery>().ReverseMap();
        }
    }
}
