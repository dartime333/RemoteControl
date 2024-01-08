namespace RemoteControl.Windows;

public partial class ControlBoardPage : ContentPage
{
	public ControlBoardPage()
	{
		InitializeComponent();
	}

    private void RemoteControlM1TurnOnBtnClicked(object sender, EventArgs e)
    {
        if (RemoteControlM1Status.Text == "OFF")
        {
            RemoteControlM1Status.Text = "ON";
            UpdatedAttemptsCount();
        }
    }

    private void UpdatedAttemptsCount()
    {
        int currentCount = Convert.ToInt32(TotalNoOfAttemps.Text);
        int attemptsCount = currentCount + 1;
        TotalNoOfAttemps.Text = attemptsCount.ToString();

        if (TotalNoOfAttempsPending.Text == "1")
        {
            TotalNoOfAttempsPending.Text = "50";
        }
        int currentBalanceCount = Convert.ToInt32(TotalNoOfAttempsPending.Text);
        int attemptsBalanceCount = currentBalanceCount - 1;
        TotalNoOfAttempsPending.Text = attemptsBalanceCount.ToString();
    }

    private void RemoteControlM1TurnOffBtnClicked(object sender, EventArgs e)
    {
        if (RemoteControlM1Status.Text == "ON")
        {
            RemoteControlM1Status.Text = "OFF";
            UpdatedAttemptsCount();
        }
    }

    private void RemoteControlM2TurnOnBtnClicked(object sender, EventArgs e)
    {
        if (RemoteControlM2Status.Text == "OFF")
        {
            RemoteControlM2Status.Text = "ON";
            UpdatedAttemptsCount();
        }
    }

    private void RemoteControlM2TurnOffBtnClicked(object sender, EventArgs e)
    {
        if (RemoteControlM2Status.Text == "ON")
        {
            RemoteControlM2Status.Text = "OFF";
            UpdatedAttemptsCount();
        }
    }

    private void RemoteControlM3TurnOnBtnClicked(object sender, EventArgs e)
    {
        if (RemoteControlM3Status.Text == "OFF")
        {
            RemoteControlM3Status.Text = "ON";
            UpdatedAttemptsCount();
        }
    }

    private void RemoteControlM3TurnOffBtnClicked(object sender, EventArgs e)
    {
        if (RemoteControlM3Status.Text == "ON")
        {
            RemoteControlM3Status.Text = "OFF";
            UpdatedAttemptsCount();
        }
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }
}

