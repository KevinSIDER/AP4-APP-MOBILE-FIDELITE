using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class ProduitVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public ProduitVue()
        {
            InitializeComponent();
        }

        private async void CreateProduct(object sender, EventArgs e)
        {
            Produit productData = new Produit();
            productData.idUser = int.Parse(IdProduitEntry.Text);
            productData.NomProduit = nomProduitEntry.Text;
            productData.PrixProduit = int.Parse(prixProduitEntry.Text);
            productData.PointsFidelite = int.Parse(pointsFideliteEntry.Text);
            productData.ImageUrl = UrlImageEntry.Text;

            var result = await _apiServices.GetOneAsync("api/mobile/creerProduit", productData);
            if (result == null)
            {
                await DisplayAlert("Erreur", "Le produit n'a pas été créé", "OK");
            }
            else
            {
                await DisplayAlert("C'est bon !", "Le produit à été crée", "OK");
            }
        }
    }
}
