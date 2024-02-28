
using My.SmartParking.Server.IService;
using My.SmartParking.Server.Models;

namespace My.SmartParking.Server.Service
{
    public class LoginService : ServiceBase,ILoginService
    {
        public LoginService(IEFContext.IEFContext dBContext):base(dBContext)
        {
            
        }
        
    }
}
