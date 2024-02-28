
using My.SmartParking.Server.IEFContext;
using MySmartParking.Server.EFCore;
namespace My.SmartParking.Server.EFContext
{
    public class EFContext : IEFContext.IEFContext
    {
        IConfiguration.IConfiguration _configuration;
        public EFContext(IConfiguration.IConfiguration configuration)
        {
            _configuration= configuration;
        }
        public EFCoreContext CreateDBContext()
        {
            return new EFCoreContext(_configuration.Read("DBConnectionStr"));
        }
    }
}
