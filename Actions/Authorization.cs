using CdekAPI.Actions.Contracts;
using Newtonsoft.Json.Linq;


namespace CdekAPI.Actions
{
    public class Authorization : IAuthorization

    {
        /// <summary>
        /// Получение строки access_token JWT-токена для авторизации
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetToken()
        {
            string tokenUrl = "https://api.edu.cdek.ru/v2/oauth/token?parameters";
            var requestData = new Dictionary<string, string>()
            {
                { "grant_type", "client_credentials" },
                { "client_id", "EMscd6r9JnFiQ3bLoyjJY6eM78JrJceI"},
                { "client_secret", "PjLZkKBHEiLK3YsjtNrt3TGNG0ahs3kG" }
            };

            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(tokenUrl, new FormUrlEncodedContent(requestData));
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    JObject jsonObject = JObject.Parse(responseContent);
                    return jsonObject["access_token"].ToString();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
