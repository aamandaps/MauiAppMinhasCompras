using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        //db campo
        static SQLiteDatabaseHelper _db;

        //db propriedade
        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine
                       (
                         Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                         "banco_sqlite_compras.db3"
                       );

                    _db = new SQLiteDatabaseHelper(path);
                }
                return _db;
            }
        }

        public App()
        {
            InitializeComponent();

            //Troca da tela inicial
           // MainPage = new AppShell();
           MainPage = new NavigationPage(new Views.ListaProduto());
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
