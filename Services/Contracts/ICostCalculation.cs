using CdekAPI.Dto;
using CdekAPI.Models;

namespace CdekAPI.Services.Contracts
{
    public interface ICostCalculation
    {
        /// <summary>
        /// Получение отфильтрованной информации по доступных тарифам доставки курьером
        /// </summary>
        /// <param name="weight">Вес в граммах.</param>
        /// <param name="height">Высота в мм.</param>
        /// <param name="length">Длина в мм.</param>
        /// <param name="width">Ширина в мм.</param>
        /// <param name="from_location">ФИАС код города отправления. </param>
        /// <param name="to_location">ФИАС код города получения.</param>
        /// <returns></returns>
        public Task<TariffsInfoDto> GetCostAsync(int weight, int height,
            int length, int width, int from_location, int to_location);
    }
}
