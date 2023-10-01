using Newtonsoft.Json;

namespace CdekAPI.Models
{
    public class TariffsInfo
    {
        [JsonProperty("tariff_codes")]
        public List<Tariff> Tariffs { get; set; }
    }
}
