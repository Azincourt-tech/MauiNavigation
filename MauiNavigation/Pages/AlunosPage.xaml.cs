using MauiNavigation.ViewModels;

namespace MauiNavigation.Pages;

public partial class AlunosPage : ContentPage
{
    public AlunosPage()
    {
        InitializeComponent();
    }

    private async void button1_Clicked(object sender, EventArgs e)
    {
        // Navegação simples passando parâmetro pelo construtor
        //await Navigation.PushAsync(new DetalhesPage(txtNome.Text));

        // Navegação simples passando parâmetro pelo BindingContext
        AlunoViewModel aluno = new AlunoViewModel();

        aluno.Nome = txtNome.Text;
        aluno.Email = txtEmail.Text;
        aluno.Idade = Convert.ToInt32(txtIdade.Text);

        await Navigation.PushAsync(new DetalhesPage
        {
            BindingContext = aluno
        });
    }
}