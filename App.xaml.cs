namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Troca da tela inicial
           // MainPage = new AppShell();
           MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
