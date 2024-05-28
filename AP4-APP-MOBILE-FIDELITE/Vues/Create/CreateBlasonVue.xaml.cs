using System.Collections.ObjectModel;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;

namespace AP4_APP_MOBILE_FIDELITE.Vues;

public partial class CreateBlasonVue : ContentPage
{
    private readonly GestionApi _apiServices = new GestionApi();
    public CreateBlasonVue()
    {
        InitializeComponent();
    }

    private async void OnCreateBlason(object sender, EventArgs e)
    {
        Blason blasonData = new Blason();
        blasonData.NomBlason = LeNomBlason.Text;
        blasonData.MontantAchats = int.Parse(LeMontantAchats.Text);

        var result = await _apiServices.GetOneAsync("api/blason/creerBlason", blasonData);
        if (result == null)
        {
            await DisplayAlert("Erreur", "Le blason n'a pas été créé", "OK");
        }
        else
        {
            await DisplayAlert("C'est bon !", "Le blason a été créé", "OK");
        }
    }
}