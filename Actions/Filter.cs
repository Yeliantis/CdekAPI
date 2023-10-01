using CdekAPI.Actions.Contracts;
using CdekAPI.Dto;

namespace CdekAPI.Actions
{
    public static class Filter
    {
        /// <summary>
        /// Фильтрация информации доступных тарифов для доставки курьером.
        /// </summary>
        /// <param name="tariffInfo">Полученная при запросе к API информация о различных тарифах.</param>
        /// <returns></returns>
        public static TariffsInfoDto FilterInfo(TariffsInfoDto tariffInfo)
        {
            TariffsInfoDto filteredTariffInfo = new TariffsInfoDto
            {
                Tariffs = tariffInfo.Tariffs
                .Where(x => x.TariffName.EndsWith("Дверь", StringComparison.OrdinalIgnoreCase))
                .ToList()
            };
            return filteredTariffInfo;
        } 
    }
}
