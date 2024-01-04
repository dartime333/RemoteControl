namespace RemoteControl.Windows;

public partial class ControlBoardPage : ContentPage
{
	public ControlBoardPage()
	{
		InitializeComponent();
	}

    private void RemoteControlM1TurnOnBtnClicked(object sender, EventArgs e)
    {
        RemoteControlM1Status.Text = "On";
    }

    private void RemoteControlM1TurnOffBtnClicked(object sender, EventArgs e)
    {
        RemoteControlM1Status.Text = "Off";
    }

    private void RemoteControlM2TurnOnBtnClicked(object sender, EventArgs e)
    {
        RemoteControlM2Status.Text = "On";
    }

    private void RemoteControlM2TurnOffBtnClicked(object sender, EventArgs e)
    {
        RemoteControlM2Status.Text = "Off";
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }
}

