using Microsoft.AspNetCore.Mvc;
using My.SmartParking.Server.IService;
using My.SmartParking.Server.Models;
using System.Linq;

namespace My.SmartParking.Server.Start.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ILoginService _loginService;
        public UserController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromForm]string username, [FromForm]string password)
        {
            if (string.IsNullOrEmpty(username)) 
            {
                throw new System.Exception("用户名不能为空");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new System.Exception("密码不能为空");
            }
            var user = _loginService.Query<SysUserInfo>(u => u.UserName == username && u.Password == password).FirstOrDefault();
            if (user == null) 
            {
                return NoContent();
            }

            return Ok(user);
            
        }
    }
}
