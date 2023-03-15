using AutoMapper;
using Core.Models;
using System.Net;

namespace API.MapperProfile
{
   

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // la primera es la DTO customizado y la segunda es el modelo entity de la base de datos
            CreateMap<PlacaVehiculoCustom, PlacaVehiculo>()
                .ForMember(dest => dest.TipoPlaca, opt => opt.MapFrom(src => src.TipoPlaca))
                .ForMember(dest => dest.NumeroPlaca, opt => opt.MapFrom(src => src.NúmeroPlaca))
                .ForMember(dest => dest.DatosCliente, opt => opt.MapFrom(src => src.DatosCliente));

            //CreateMap<AddressModel, Address>().ReverseMap();
        }
    }
}
