using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class CreateProduct : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public CreateProduct()
        {
            InitializeComponent();
        }

        private async void OnCreateProduct(object sender, EventArgs e)
        {
            Product productData = new Product();

            // Convertir l'objet User en une cha�ne JSON
            string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);

            // D�s�rialiser la cha�ne JSON en un objet JObject
            JObject currentUserJson = JObject.Parse(currentUserJsonString);

            // Acc�der � la propri�t� id dans l'objet JObject
            int id = (int)currentUserJson["id"];
            // Utiliser l'ID de l'utilisateur actuel

            productData.ID = id;
            productData.NomProduit = NomProduitEntry.Text;
            productData.PrixProduit = double.Parse(PrixProduitEntry.Text);
            productData.PointsFidelite = int.Parse(PointsFideliteEntry.Text);
            productData.ImageUrl = ImageUrlEntry.Text;

            var result = await _apiServices.GetOneAsync("api/mobile/creerProduit", productData);
            if (result == null)
            {
                await DisplayAlert("Erreur", "Le produit n'a pas �t� cr��", "OK");
            }
            else
            {
                await DisplayAlert("C'est bon !", "Le produit a �t� cr��", "OK");
            }
        }
    }
}
