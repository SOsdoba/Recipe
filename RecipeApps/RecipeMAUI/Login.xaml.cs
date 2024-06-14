using RecipeAppSystem;

namespace RecipeMAUI;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private async void LoginBtn_Clicked(object sender, EventArgs e)
	{
		try
		{
			Messagelbl.Text = "";
			DBManager.SetConnectionString(App.ConnStringSetting, true, UserNameTxt.Text, PasswordTxt.Text);
			App.LoggedIn = true;
			await Navigation.PopModalAsync();
		}
		catch(Exception ex)
		{
			Messagelbl.Text = ex.Message;
		}
	}

	private void CancelBtn_Clicked(object sender, EventArgs e)
	{
		Application.Current.Quit();
	}
}