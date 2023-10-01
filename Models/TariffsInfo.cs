using Newtonsoft.Json;

namespace CdekAPI.Models
{
    public class TariffsInfo
    {
        [JsonProperty("tariff_codes")]
        ///Список всех тарифов
        public List<Tariff> Tariffs { get; set; }
    }
}
