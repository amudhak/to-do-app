namespace to_do_app;
using to_do_app.ViewModel;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}


