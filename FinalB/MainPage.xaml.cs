namespace FinalB;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	public void OnVisitWebsiteClicked(object sender, EventArgs e)
	{
		Launcher.OpenAsync(new Uri("https://www.nasa.gov/multimedia/imagegallery/index.html"));
	}


}

