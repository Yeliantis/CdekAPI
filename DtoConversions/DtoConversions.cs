using CdekAPI.Dto;
using CdekAPI.Models;

namespace CdekAPI.DtoConversions
{
    public static class DtoConversions
    {
        /// <summary>
        /// Конвертация Tariff в TariffDto.
        /// </summary>
        /// <param name="tariffs">Тариф до конвертации.</param>
        /// <returns></returns>
        public static List<TariffDto> ConvertToDto(this List<Tariff> tariffs)
        {
            return (from tariff in tariffs
                    select new TariffDto
                    {
                        TariffName = tariff.TariffName,
                        DeliverySum = tariff.DeliverySum,
                    }).ToList();
        }

        /// <summary>
        /// Конвертация информации о тарифах
        /// </summary>
        /// <param name="tariffInfo">Информация о всех тарифах до конвертации.</param>
        /// <returns></returns>
        public static TariffsInfoDto ConvertToDt(this TariffsInfo tariffInfo)
        {
            var tariffs = ConvertToDto(tariffInfo.Tariffs);
            return new TariffsInfoDto
            {
                Tariffs = tariffs
            };
        }
    }
}
