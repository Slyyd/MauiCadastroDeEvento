using MauiCadastroDeEvento.Models;

namespace MauiCadastroDeEvento.Views;

public partial class CadastroCompleto : ContentPage
{
	public CadastroCompleto(Evento novaInstancia)
	{
		InitializeComponent();


		BindingContext = novaInstancia;

		TimeSpan duracaoDias = novaInstancia.dataFim - novaInstancia.dataInicio;

		str_duracao.Text = $"{duracaoDias.Days} dias";

		double custoTotal = (novaInstancia.custoParticipante * novaInstancia.quantParticipantes) * duracaoDias.Days;

		str_custototal.Text = $"R$ {custoTotal}";

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.MainPage());
    }
}