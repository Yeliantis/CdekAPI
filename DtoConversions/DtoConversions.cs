using CdekAPI.Dto;
using CdekAPI.Models;

namespace CdekAPI.DtoConversions
{
    public static class DtoConversions
    {
        public static List<TariffDto> ConvertToDto(this List<Tariff> tariffs)
        {
            return (from tariff in tariffs
                    select new TariffDto
                    {
                        TariffName = tariff.TariffName,
                        DeliverySum = tariff.DeliverySum,
                    }).ToList();
        }

        public static TariffsInfoDto ConvertToDt(this TariffsInfo dto)
        {
            var tariffs = ConvertToDto(dto.Tariffs);
            return new TariffsInfoDto
            {
                Tariffs = tariffs
            };
        }
    }
}
