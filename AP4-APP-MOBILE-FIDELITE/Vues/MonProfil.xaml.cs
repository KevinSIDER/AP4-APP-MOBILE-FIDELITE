using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues;

public partial class MonProfil : ContentPage
{
    public MonProfil()
    {
        InitializeComponent();
        ShowMyProfil();
    }

    private void ShowMyProfil()
    {
        string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
        JObject currentUserJson = JObject.Parse(currentUserJsonString);
        string nom = (string)currentUserJson["nom"];
        string prenom = (string)currentUserJson["prenom"];
        string email = (string)currentUserJson["email"];
        int ptnFidelite = (int)currentUserJson["stockPointFidelite"];
        int telephone = (int)currentUserJson["telephone"];
        DateTime dateNaissance = (DateTime)currentUserJson["dateNaissance"];

        UserInfoLabel.Text = $"Nom : {nom}\n" +
                             $"Prénom : {prenom}\n" +
                             $"Email : {email}\n" +
                             $"Points de fidélité : {ptnFidelite}\n" +
                             $"Téléphone : {telephone}\n" +
                             $"Date de naissance : {dateNaissance:dd/MM/yyyy}";
    }

    private async void goShowCommandes(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GetAllCommandes());
    }
}
