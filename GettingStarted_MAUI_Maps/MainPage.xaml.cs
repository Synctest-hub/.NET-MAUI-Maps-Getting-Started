using Syncfusion.Maui.Maps;

namespace GettingStarted_MAUI_Maps;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.layer.ShapesSource = MapSource.FromResource("GettingStarted_MAUI_Maps.australia.json");
	}

}

