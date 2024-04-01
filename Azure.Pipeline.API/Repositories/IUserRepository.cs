namespace Azure.Pipeline.API.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<Models.User> GetUsers();
    }
}
