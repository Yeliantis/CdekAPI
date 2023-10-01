namespace CdekAPI.Actions.Contracts
{
    public interface IAuthorization
    {
        public Task<string> GetToken();
    }
}
