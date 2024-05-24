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
            AfficherInfos();  // Appel de ma méthode dès l'affichage
        }

        private void AfficherInfos()
        {
            string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
            JObject currentUserJson = JObject.Parse(currentUserJsonString);
            string nom = (string)currentUserJson["nom"];
            string prenom = (string)currentUserJson["prenom"];
            int ptnFidelite = (int)currentUserJson["stockPointFidelite"];

            UserInfoLabel.Text = $" Bonjour {prenom} ,vous avez {ptnFidelite} points de pismafidelité !";
        }

        private async void goEditor(object sender, EventArgs e) // Créer des éléments dans la BDD
        {
            await Navigation.PushAsync(new Editor());
        }

        private async void ShowBlasons(object sender, EventArgs e) // Afficher tout les blasons
        {
            await Navigation.PushAsync(new GetAllBlason());
        }
    }
}
