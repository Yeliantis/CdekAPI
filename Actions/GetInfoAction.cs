using CdekAPI.Actions.Contracts;
using CdekAPI.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace CdekAPI.Actions
{
    public class GetInfoAction : IGetInfoAction
    {
        private readonly IAuthorization _auth;
        public GetInfoAction(IAuthorization auth)
        {
            _auth = auth;
        }
        /// <summary>
        /// отправка запроса на API СДЭК и десериализация данных с целью получения списка тарифов для доставки
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="from_location"></param>
        /// <param name="to_location"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<TariffsInfo> GetInfoAsync(int weight, int height, int length, int width, int from_location, int to_location)
        {
            string token = await _auth.GetToken();
            var url = "https://api.edu.cdek.ru/v2/calculator/tarifflist";
            var dataToSend = new
            {
                type = 2,
                from_location = new
                {
                    code = from_location
                },
                to_location = new
                {
                    code = to_location
                },
                packages = new[]
                   {
                      new
                      {
                       height = (int)Math.Ceiling(height/10.0),
                       length = (int)Math.Ceiling(length/10.0),
                       weight = weight,
                       width = (int)Math.Ceiling(width/10.0)
                      }
                   }
            };
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var jsonContent = JsonConvert.SerializeObject(dataToSend);
                HttpContent httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, httpContent);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<TariffsInfo>(responseContent);
                    return result;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }
    }
}
