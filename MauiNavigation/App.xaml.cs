using MauiNavigation.Pages;

namespace MauiNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new AlunosPage()));
        }
    }
}