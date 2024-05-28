using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class CreateProductVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public CreateProductVue()
        {
            InitializeComponent();
        }

        private async void OnCreateProduct(object sender, EventArgs e)
        {
            Product productData = new Product();

            string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
            JObject currentUserJson = JObject.Parse(currentUserJsonString);
            int id = (int)currentUserJson["id"];

            productData.ID = id;
            productData.NomProduit = NomProduitEntry.Text;
            productData.PrixProduit = double.Parse(PrixProduitEntry.Text);
            productData.PointsFidelite = int.Parse(PointsFideliteEntry.Text);
            productData.ImageUrl = ImageUrlEntry.Text;

            var result = await _apiServices.GetOneAsync("api/mobile/creerProduit", productData);
            if (result == null)
            {
                await DisplayAlert("Erreur", "Le produit n'a pas été créé", "OK");
            }
            else
            {
                await DisplayAlert("C'est bon !", "Le produit a été créé", "OK");
            }
        }
    }
}