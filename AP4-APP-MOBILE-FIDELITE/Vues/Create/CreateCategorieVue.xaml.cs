using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class CreateCategorieVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public CreateCategorieVue()
        {
            InitializeComponent();
        }

        private async void OnCreateCategorie(object sender, EventArgs e)
        {
            Categorie categorieData = new Categorie();
            categorieData.ID = Constantes.CurrentUser.Id;
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