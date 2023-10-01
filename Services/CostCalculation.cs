using CdekAPI.Actions;
using CdekAPI.Actions.Contracts;
using CdekAPI.Dto;
using CdekAPI.DtoConversions;
using CdekAPI.Models;
using CdekAPI.Services.Contracts;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;


namespace CdekAPI.Services
{
    public class CostCalculation : ICostCalculation
    {
        private readonly IAuthorization _auth;
        private readonly IGetInfoAction _infoAction;
        public CostCalculation(IAuthorization auth, IGetInfoAction infoAction)
        {
            _auth= auth;
            _infoAction = infoAction;
        }
        public async Task<TariffsInfoDto> GetCostAsync(int weight, int height, int length, int width, int from_location, int to_location)
        {
            
                var result = await _infoAction.GetInfoAsync(weight, height, length, width, from_location, to_location);
                var resultDto = result.ConvertToDt();
                return Filter.FilterInfo(resultDto);
            
        }
    }
}
