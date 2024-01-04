using Microsoft.Maui.Graphics.Text;
using RemoteControl.Windows;
using System.ComponentModel;

namespace RemoteControl
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLogInClicked(object sender, EventArgs e)
        {
            var userId = "itron";
            var pwd = "123";
            if ((UserNameTxt.Text != string.Empty) || PasswordTxt.Text != string.Empty)
            {
                if ((userId == UserNameTxt.Text) && (pwd == PasswordTxt.Text))
                {
                    LoginErrorMsgLable.IsVisible = false;
                    Application.Current.MainPage = new NavigationPage(new ControlBoardPage());
                }
                else
                {
                    LoginErrorMsgLable.IsVisible = true;
                }
            }
            else
            {
                LoginErrorMsgLable.Text = "Please provide User Name, Password!";
                LoginErrorMsgLable.IsVisible = true;
            }
            
        }
    }

}
