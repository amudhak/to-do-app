using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace to_do_app.ViewModel;

[QueryProperty("Text", "Text")]

public partial class DetailViewModel : ObservableObject
{
    public DetailViewModel()
    {
        
    }

    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    void OnEditorTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = ((Editor)sender).Text;
    }

    void OnEditorCompleted(object sender, EventArgs e)
    {
        string text = ((Editor)sender).Text;
    }
}