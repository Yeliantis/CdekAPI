namespace CdekAPI.Actions.Contracts
{
    public interface IAuthorization
    {
        /// <summary>
        /// Получение строки значения access_token JWT-токена для авторизации.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetToken();
    }
}
