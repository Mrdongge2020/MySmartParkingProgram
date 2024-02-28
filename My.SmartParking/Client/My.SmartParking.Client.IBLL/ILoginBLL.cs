namespace My.SmartParking.Client.IBLL
{
    public interface ILoginBLL
    {
        Task<bool> Login(string username, string password);
    }
}
