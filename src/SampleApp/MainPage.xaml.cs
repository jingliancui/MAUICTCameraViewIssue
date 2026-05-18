namespace SampleApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		Loaded+=MainPage_Loaded;
	}

	private async void MainPage_Loaded(object? sender,EventArgs e)
	{
		await Permissions.RequestAsync<Permissions.Camera>();
		await Permissions.RequestAsync<Permissions.Microphone>();
	}
}
