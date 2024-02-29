using My.SmartParking.Client.IBLL;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace My.SmartParking.Client.Start.ViewModels
{
    public class LoginViewModel:BindableBase
    {
        ILoginBLL _loginBLL;
        public LoginViewModel(ILoginBLL loginBLL)
        {
            _loginBLL = loginBLL;
        }

        private string _userName="admin";   
        public string UserName 
        { 
            get { return _userName; }
            set { SetProperty<string>(ref  _userName , value); }
        }

        private string _password="123456";

        public string Password
        {
            get { return _password; }
            set { SetProperty<string>(ref _password, value); }
        }

        private string _errorMsg;

        public string ErrorMsg
        {
            get { return _errorMsg; }
            set { SetProperty<string>(ref _errorMsg, value); }
        }
        //public string UserName { get; set; }

        //public string Password { get; set; }

        //登录命令
        public ICommand LoginCommand
        {
            get => new DelegateCommand<object>(OnLogin);
        }

        //登录命令
        private void OnLogin(object obj) 
         {
            try
            {
                this.ErrorMsg = "";
                if (string.IsNullOrEmpty(this.UserName))
                {
                    this.ErrorMsg = "请输入用户名";
                    return;
                }
                if (string.IsNullOrEmpty(this.Password))
                {
                    this.ErrorMsg = "请输入密码";
                    return;
                }

                //登录操作
                if(_loginBLL.Login(this.UserName, this.Password).GetAwaiter().GetResult())
                {
                    //关闭登录窗口，并且DialogResult返回true；
                    (obj as Window).DialogResult = true;
                };
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
