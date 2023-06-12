namespace to_do_app;
using to_do_app.ViewModel;

public partial class DetailPage : ContentPage
{
    string text;

    public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    void OnEditorTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
    }

    void OnEditorCompleted(object sender, EventArgs e)
    {
        text = ((Editor)sender).Text;
    }
}
