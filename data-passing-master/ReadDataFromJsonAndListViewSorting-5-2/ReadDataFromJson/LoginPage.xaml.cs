using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReadDataFromJson
{
    public partial class LoginPage : ContentPage
    {
		protected LoginPageViewModel vm;

		public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = new LoginPageViewModel(this.Navigation);
        }
    }
}
