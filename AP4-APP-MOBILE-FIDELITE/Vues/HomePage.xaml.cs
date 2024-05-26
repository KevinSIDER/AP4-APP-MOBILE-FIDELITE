using System.Collections.ObjectModel;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using AP4_APP_MOBILE_FIDELITE.Vues;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            ShowUserInfos();  // Appel de ma méthode dès l'affichage
        }

        private void ShowUserInfos()
        {
            string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
            JObject currentUserJson = JObject.Parse(currentUserJsonString);
            string nom = (string)currentUserJson["nom"];
            string prenom = (string)currentUserJson["prenom"];
            int ptnFidelite = (int)currentUserJson["stockPointFidelite"];

            UserInfoLabel.Text = $" Bonjour {prenom} ,vous avez {ptnFidelite} points de pismafidelité !";
        }

        //Créer des éléments
        private async void goEditor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Editor());
        }

        private async void GoCreateCommander(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateCommander());
        }

        //Afficher des éléments

        private async void ShowBlasons(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetAllBlason());
        }

        private async void GoShowAllProduct(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetAllProduits());
        }

        private async void GoShowMyProfil(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MonProfil());
        }
    }
}