using Newtonsoft.Json;

namespace CdekAPI.Models
{
    public class Tariff
    {
        [JsonProperty("tariff_code")]
        ///Код тарифа доставки
        public int TariffCode { get; set; }
        [JsonProperty("tariff_name")]
        ///Название тарифа
        public string? TariffName { get; set; }
        [JsonProperty("tariff_description")]
        ///Описание тарифа
        public string? TariffDescription { get; set; }
        [JsonProperty("delivery_mode")]
        ///Режим тарифа
        public int DeliveryMode { get; set; }
        [JsonProperty("delivery_sum")]
        ///Стоимость доставки
        public double DeliverySum { get; set; }
        [JsonProperty("period_max")]
        /// Максимальное время доставки (в рабочих днях)
        public int PeriodMax { get; set; }
        [JsonProperty("period_min")]
        ///Минимальное время доставки (в рабочих днях)
        public int PeriodMin { get; set; }
        [JsonProperty("calendar_max")]
        ///Максимальное время доставки (в календарных днях)
        public int CalendarMax { get; set; }
        [JsonProperty("calendar_min")]
        ///Минимальное время доставки (в календарных днях)
        public int CalendarMin { get; set; }
    }
}
