using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace My.SmartParking.Client.Start.ViewModels
{
    public class LoginViewModel:BindableBase
    {

        private string _userName="admin";   
        public string UserName 
        { 
            get { return _userName; }
            set { SetProperty<string>(ref  _userName , value); }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { SetProperty<string>(ref _password, value); }
        }
        //public string UserName { get; set; }

        //public string Password { get; set; }

        //登录命令
        public ICommand LoginCommand
        {
            get => new DelegateCommand<object>(OnLogin);
        }

        private void OnLogin(object obj) 
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
