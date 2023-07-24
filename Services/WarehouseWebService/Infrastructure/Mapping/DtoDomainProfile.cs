using AutoMapper;
using WarehouseWebService.Data.Domain;

namespace WarehouseWebService.Infrastructure.Mapping
{
    public class DtoDomainProfile : Profile
    {
        public DtoDomainProfile()
        {
            CreateMap<Product, Data.Dto.ModelDto.Product>().ReverseMap();
            CreateMap<Warehouse, Data.Dto.ModelDto.Warehouse>().ReverseMap();
            CreateMap<Shipment, Data.Dto.ModelDto.Shipment>().ReverseMap();
            CreateMap<Supplier, Data.Dto.ModelDto.Supplier>().ReverseMap();
            CreateMap<ShipmentDestination, Data.Dto.ModelDto.ShipmentDestination>().ReverseMap();
            CreateMap<ProductStock, Data.Dto.ModelDto.ProductStock>().ReverseMap();
            CreateMap<Delivery, Data.Dto.ModelDto.Delivery>().ReverseMap();
        }
    }
}
