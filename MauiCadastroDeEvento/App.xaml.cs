
using MauiCadastroDeEvento.Models;

namespace MauiCadastroDeEvento
{
    public partial class App : Application
    {

        public List<Locais> lista_locais = new List<Locais>
        {

            new Locais()
            {
                descricao = "Expo Center Norte",
                endereco = "Rua José Bernardo Pinto, 333 - Vila Guilherme, São Paulo - SP"
            },

            new Locais()
            {
                descricao = "São Paulo Expo",
                endereco = "Rodovia dos Imigrantes, 1,5 km - Vila Água Funda, São Paulo - SP"
            }

        };




        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.MainPage());

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 450;
            window.Height = 800;

            return window;


        }





    }
}
