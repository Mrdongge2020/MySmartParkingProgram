namespace My.SmartParking.Client.IDAL
{
    public interface ILoginDal
    {
        Task<string> Login(string username, string password);
    }
}
