namespace MeuEvento
{
    public partial class Resumo : ContentPage
    {
        public Resumo()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}