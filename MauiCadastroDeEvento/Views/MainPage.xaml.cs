using MauiCadastroDeEvento.Models;

namespace MauiCadastroDeEvento.Views;

public partial class MainPage : ContentPage
{

    App propriedadesApp;

	public MainPage()
	{
		InitializeComponent();

        propriedadesApp = (App)Application.Current;

        pck_local.ItemsSource = propriedadesApp.lista_locais; // Setando a lista do picker

        dtp_inicio.MinimumDate = DateTime.Now;
        dtp_inicio.MaximumDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);

        dtp_fim.MinimumDate = dtp_inicio.Date.AddDays(30);
        dtp_fim.MaximumDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month + 1, DateTime.Now.Day);

	}


    private async void Button_Clicked(object sender, EventArgs e)
    {

        try
        {
            var novaInstancia = new Evento
                    {
                        nome = etr_nome.Text,
                        dataInicio = dtp_inicio.Date,
                        dataFim = dtp_fim.Date,
                        local = (Locais)pck_local.SelectedItem,
                        custoParticipante = double.Parse(etr_custo.Text),
                        quantParticipantes = (int)sld_participantes.Value
                    };

                    await Navigation.PushAsync(new Views.CadastroCompleto(novaInstancia));
        }
        catch (Exception ex) { await DisplayAlert("Erro", "Houve um problema, tente novamente!", "OK"); }
        

    }

    private void sld_participantes_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        sld_participantes.Value = (int)Math.Round(sld_participantes.Value);
    }

    private void dtp_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = (DatePicker)sender;
        DateTime data_sel = elemento.Date;

        dtp_fim.MinimumDate = data_sel.AddMonths(1);
        dtp_fim.MaximumDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
    }
}