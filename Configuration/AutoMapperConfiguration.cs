using AutoMapper;
using CdekAPI.Dto;
using CdekAPI.Models;

namespace CdekAPI.Configuration
{
    public static class AutoMapperConfiguration
    {
        
        public static Mapper CreateMapper()
        {
            return new Mapper(ConfigureMapper());
        }
        private static MapperConfiguration ConfigureMapper()
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<Tariff, TariffDto>();
                config.CreateMap<TariffsInfo, TariffsInfoDto>()
                .ForMember(x => x.Tariffs, opt => opt.MapFrom(src => src.Tariffs));

            });
        }

    }
}
