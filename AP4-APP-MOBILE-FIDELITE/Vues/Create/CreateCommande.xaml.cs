namespace AP4_APP_MOBILE_FIDELITE.Vues;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

public partial class CreateCommande : ContentPage
{

    private readonly GestionApi _apiServices = new GestionApi();
    public CreateCommande()
    {
        InitializeComponent();
    }

    private async void OnCreateCommande(object sender, EventArgs e)
    {
        Commande commandeData = new Commande();

        string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
        JObject currentUserJson = JObject.Parse(currentUserJsonString);
        int id = (int)currentUserJson["id"];
        commandeData.ID = id;
        commandeData.Etat = "En cours";

        var result = await _apiServices.GetOneAsync("api/mobile/creerCommande", commandeData);
        if (result == null)
        {
            await DisplayAlert("Erreur", "La commande n'a pas été créée", "OK");
        }
        else
        {
            await DisplayAlert("C'est bon !", "La commande a été créé", "OK");
        }
    }
}