using AP4_APP_MOBILE_FIDELITE.Vues;

namespace AP4_APP_MOBILE_FIDELITE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Page d'accueil de l'application

            MainPage = new NavigationPage(new Login());

        }
    }
}