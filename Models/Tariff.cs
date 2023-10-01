using Newtonsoft.Json;

namespace CdekAPI.Models
{
    public class Tariff
    {
        [JsonProperty("tariff_code")]
        public int TariffCode { get; set; }
        [JsonProperty("tariff_name")]
        public string? TariffName { get; set; }
        [JsonProperty("tariff_description")]
        public string? TariffDescription { get; set; }
        [JsonProperty("delivery_mode")]
        public int DeliveryMode { get; set; }
        [JsonProperty("delivery_sum")]
        public double DeliverySum { get; set; }
        [JsonProperty("period_max")]
        public int PeriodMax { get; set; }
        [JsonProperty("period_min")]
        public int PeriodMin { get; set; }
        [JsonProperty("calendar_max")]
        public int CalendarMax { get; set; }
        [JsonProperty("calendar_min")]
        public int CalendarMin { get; set; }
    }
}
