namespace AP4_APP_MOBILE_FIDELITE.Vues;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

public partial class CreateCommanderVue : ContentPage
{

    private readonly GestionApi _apiServices = new GestionApi();
    public CreateCommanderVue()
    {
        InitializeComponent();
    }

    private async void OnCreateCommander(object sender, EventArgs e)
    {
        Commander commanderData = new Commander();
        commanderData.Id = Constantes.CurrentUser.Id;
        commanderData.UserID = Constantes.CurrentUser.Id;
        commanderData.Quantite = int.Parse(QuantiteEntry.Text);
        commanderData.LeProduit = int.Parse(LeProduitEntry.Text);
        commanderData.LaCommande = int.Parse(LaCommandeEntry.Text);

        var result = await _apiServices.GetOneAsync("api/mobile/creerCommander", commanderData);
        if (result != null)
        {
            await DisplayAlert("C'est bon !", JsonConvert.SerializeObject(commanderData), "OK");
        }
        else
        {
            await DisplayAlert("Erreur", "Votre article n'a pas été commandé", "OK");
        }
    }
}