using AP4_APP_MOBILE_FIDELITE.Vues;
using Newtonsoft.Json;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class Login : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public Login()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // 1. Validation des entrées utilisateur
            if (string.IsNullOrWhiteSpace(EmailEntry.Text) || string.IsNullOrWhiteSpace(PasswordEntry.Text))
            {
                await DisplayAlert("Erreur", "Veuillez entrer votre email et votre mot de passe.", "OK");
                return;
            }

            User userData = new User();
            userData.Email = EmailEntry.Text;
            userData.Password = PasswordEntry.Text;

            try
            {
                var response = await _apiServices.GetOneAsync("api/mobile/GetFindUser", userData);
                if (response != null)
                {
                    await Navigation.PushAsync(new AccueilVue());
                    Constantes.CurrentUser = response;
                }
                else
                {
                    await DisplayAlert("Erreur", "Une erreur s'est produite lors de la connexion. Veuillez réessayer.", "OK");
                }
            }
            catch (Exception ex)
            {
                // 3. Gestion des erreurs de l'API
                await DisplayAlert("Erreur", $"Une erreur s'est produite lors de la connexioner : {ex.Message}", "OK");
            }
        }

        private async void OnLabelTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InscriptionVue());
        }
    }
}