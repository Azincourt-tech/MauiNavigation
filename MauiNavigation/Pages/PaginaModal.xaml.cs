namespace MauiNavigation.Pages;

public partial class PaginaModal : ContentPage
{
    public PaginaModal()
    {
        InitializeComponent();
    }

    private async void button1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}