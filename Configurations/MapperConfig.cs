using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.DTO.Country;
using HotelListing.API.DTO.Hotel;

namespace HotelListing.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
            CreateMap<Hotel, GetHotelDto>()
                .ForMember(dest => dest.CountryName, act => act.MapFrom(src => src.Country.Name));
        }
    }
}
