using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Xamarin.Forms;
namespace ReadDataFromJson
{
    public class LoginPageViewModel:ViewModelBase
    {
		public INavigation _navigation;

        public Command _logincommand;
		public Command LoginCommand => _logincommand ?? (_logincommand = new Command(ExecuteSignInUserCommand));
		private async void ExecuteSignInUserCommand()
		{
			await Application.Current.MainPage.Navigation.PushAsync(new ReadDataFromJsonPage(UserName));
		}
		public string _userName;
		public string UserName
		{
            get { return _userName; }
			set
			{
                //if (_userName != value)
				//{
                    _userName = value;
					OnPropertyChanged("UserName");
				//}
			}
		}

	    string _password;
		public string Password
		{
			get { return _password; }
			set
			{
				if (_password != value)
				{
					_password = value;
					OnPropertyChanged("Password");
				}
			}
		}

	

        public LoginPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
    }
}
