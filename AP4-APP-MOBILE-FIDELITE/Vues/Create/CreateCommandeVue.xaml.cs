namespace AP4_APP_MOBILE_FIDELITE.Vues;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

public partial class CreateCommandeVue : ContentPage
{

    private readonly GestionApi _apiServices = new GestionApi();
    public CreateCommandeVue()
    {
        InitializeComponent();
    }

    private async void OnCreateCommande(object sender, EventArgs e)
    {
        Commande commandeData = new Commande();
        commandeData.ID = Constantes.CurrentUser.Id;
        commandeData.Etat = "En cours";

        var result = await _apiServices.GetOneAsync("api/mobile/creerCommande", commandeData);
        if (result == null)
        {
            await DisplayAlert("Erreur", "La commande n'a pas �t� cr��e", "OK");
        }
        else
        {
            await DisplayAlert("C'est bon !", "La commande a �t� cr��", "OK");
        }
    }
}