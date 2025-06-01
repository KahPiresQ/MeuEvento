namespace MeuEvento
{
    public partial class App : Application
    {
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            // Define tamanho da janela (largura x altura)
            window.Width = 400;
            window.Height = 800;

            return window;
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Cadastro());
        }
    }
}
