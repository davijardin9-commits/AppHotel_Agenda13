namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var paginaInicial = new Views.ContratacaoHospedagem();

            var botaoSobre = new ToolbarItem
            {
                Text = "Sobre"
            };

            botaoSobre.Clicked += async (sender, e) =>
            {
                await paginaInicial.Navigation.PushAsync(new Sobre());
            };

            paginaInicial.ToolbarItems.Add(botaoSobre);

            MainPage = new NavigationPage(paginaInicial)
            {
                BarBackgroundColor = Color.FromArgb("#17365D"),
                BarTextColor = Colors.White
            };
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
