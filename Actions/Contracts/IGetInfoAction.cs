using CdekAPI.Models;

namespace CdekAPI.Actions.Contracts
{
    public interface IGetInfoAction
    {
        public Task<TariffsInfo> GetInfoAsync(int weight, int height, int length, int width, int from_location, int to_location);
    }
}
