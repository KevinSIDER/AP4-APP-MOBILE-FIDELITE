using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class CreateCategorie : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public CreateCategorie()
        {
            InitializeComponent();
        }

        private async void OnCreateCategorie(object sender, EventArgs e)
        {
            Categorie categorieData = new Categorie();

            // Convertir l'objet User en une chaîne JSON
            string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);

            // Désérialiser la chaîne JSON en un objet JObject
            JObject currentUserJson = JObject.Parse(currentUserJsonString);

            // Accéder à la propriété id dans l'objet JObject
            int id = (int)currentUserJson["id"];
            // Utiliser l'ID de l'utilisateur actuel

            categorieData.ID = id;
            categorieData.nomCategorie = NomCategorieEntry.Text;
            categorieData.urlImage = ImageUrlEntry.Text;

            var result = await _apiServices.GetOneAsync("api/mobile/creerCategorie", categorieData);
            if (result == null)
            {
                await DisplayAlert("Erreur", "La catégorie n'a pas été créé", "OK");
            }
            else
            {
                await DisplayAlert("C'est bon !", "La catégorie a été créé", "OK");
            }
        }
    }
}