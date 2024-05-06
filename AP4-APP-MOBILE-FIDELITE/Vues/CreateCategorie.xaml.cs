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

            // Convertir l'objet User en une cha�ne JSON
            string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);

            // D�s�rialiser la cha�ne JSON en un objet JObject
            JObject currentUserJson = JObject.Parse(currentUserJsonString);

            // Acc�der � la propri�t� id dans l'objet JObject
            int id = (int)currentUserJson["id"];
            // Utiliser l'ID de l'utilisateur actuel

            categorieData.ID = id;
            categorieData.nomCategorie = NomCategorieEntry.Text;
            categorieData.urlImage = ImageUrlEntry.Text;

            var result = await _apiServices.GetOneAsync("api/mobile/creerCategorie", categorieData);
            if (result == null)
            {
                await DisplayAlert("Erreur", "La cat�gorie n'a pas �t� cr��", "OK");
            }
            else
            {
                await DisplayAlert("C'est bon !", "La cat�gorie a �t� cr��", "OK");
            }
        }
    }
}