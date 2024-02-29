using My.SmartParking.Client.IBLL;
using My.SmartParking.Client.IDAL;

namespace My.SmartParking.Client.BLL
{
    public class LoginBLL : ILoginBLL
    {
        ILoginDal _loginDal;
        public LoginBLL(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }
        public async Task<bool> Login(string username, string password)
        {
            var loginStr=await _loginDal.Login(username, password);

            return false;
        }
    }
}
