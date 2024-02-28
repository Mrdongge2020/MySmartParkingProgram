using MySmartParking.Server.EFCore;

namespace My.SmartParking.Server.IEFContext
{
    public interface IEFContext
    {
        EFCoreContext CreateDBContext();
    }
}
