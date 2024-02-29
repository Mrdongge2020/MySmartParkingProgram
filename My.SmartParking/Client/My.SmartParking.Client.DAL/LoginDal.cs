using My.SmartParking.Client.IDAL;

namespace My.SmartParking.Client.DAL
{
    public class LoginDal : WebDataAccess,ILoginDal
    {
        public Task<string> Login(string username, string password)
        {
            Dictionary<string, HttpContent> contents = new Dictionary<string, HttpContent>();
            contents.Add("username",new StringContent(username));
            contents.Add("password", new StringContent(password));
                                                 return this.PostDatas("user/login",contents);
        }
    }
}
