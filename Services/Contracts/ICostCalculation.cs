using CdekAPI.Dto;
using CdekAPI.Models;

namespace CdekAPI.Services.Contracts
{
    public interface ICostCalculation
    {
        public Task<TariffsInfoDto> GetCostAsync(int weight, int height,
            int length, int width, int from_location, int to_location);
    }
}
