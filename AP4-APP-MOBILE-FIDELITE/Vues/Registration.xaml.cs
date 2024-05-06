using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;

namespace AP4_APP_MOBILE_FIDELITE.Vues;

public partial class InscriptionVue : ContentPage
{
    private readonly GestionApi _apiServices = new GestionApi();

    public InscriptionVue()
    {
        InitializeComponent();
    }

    private async void OnInscriptionClicked(object sender, EventArgs e)
    {
        User userData = new User();
        {
            userData.Email = emailEntry.Text;
            userData.Nom = nomEntry.Text;
            userData.Prenom = prenomEntry.Text;
            userData.Password = passwordEntry.Text;
            userData.Telephone = telephoneEntry.Text;
            userData.DateNaissance = dateNaissancePicker.Date;
        };

        var result = await _apiServices.GetOneAsync("api/mobile/setInscription", userData);
        if (result == null)
        {
            await DisplayAlert("Erreur", "L'inscription a échoué.", "OK");
        }
        else
        {
            await Navigation.PushAsync(new Login());
        }
    }
}