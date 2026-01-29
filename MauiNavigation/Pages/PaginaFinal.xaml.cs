namespace MauiNavigation.Pages;

public partial class PaginaFinal : ContentPage
{
    public PaginaFinal()
    {
        InitializeComponent();
    }

    private async void button1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void button2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}