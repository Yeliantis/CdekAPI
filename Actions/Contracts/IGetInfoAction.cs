using CdekAPI.Models;

namespace CdekAPI.Actions.Contracts
{
    public interface IGetInfoAction
    {
        /// <summary>
        /// Отправка запроса на API СДЭК и десериализация данных с целью получения списка тарифов для доставки.
        /// </summary>
        /// <param name="weight">Вес в граммах.</param>
        /// <param name="height">Высота в мм.</param>
        /// <param name="length">Длина в мм.</param>
        /// <param name="width">Ширина в мм.</param>
        /// <param name="from_location">ФИАС код города отправления. </param>
        /// <param name="to_location">ФИАС код города получения.</param>
        /// <returns></returns>
        public Task<TariffsInfo> GetInfoAsync(int weight, int height, int length, int width, int from_location, int to_location);
    }
}
