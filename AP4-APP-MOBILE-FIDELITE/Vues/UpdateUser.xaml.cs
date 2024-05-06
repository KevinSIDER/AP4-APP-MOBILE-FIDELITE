using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class UpdateUser : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public UpdateUser()
        {
            InitializeComponent();
        }

        private async void OnUpdateUserClicked(object sender, EventArgs e)
        {
            try
            {
                User updateUserData = new User();

                // Convertir l'objet User en une chaîne JSON
                string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);

                // Désérialiser la chaîne JSON en un objet JObject
                JObject currentUserJson = JObject.Parse(currentUserJsonString);

                // Accéder à la propriété id dans l'objet JObject
                int id = (int)currentUserJson["id"];
                // Utiliser l'ID de l'utilisateur actuel

                updateUserData.Id = id;
                updateUserData.Email = emailEntry.Text;
                updateUserData.Nom = nomEntry.Text;
                updateUserData.Prenom = prenomEntry.Text;
                updateUserData.Telephone = telephoneEntry.Text;
                updateUserData.DateNaissance = dateNaissancePicker.Date;

                // debug
                string jsonData = JsonConvert.SerializeObject(updateUserData);
                await DisplayAlert("Données JSON", jsonData, "OK");

                var result = await _apiServices.GetOneAsync<User>("api/mobile/updateUser", updateUserData);

                if (result == null)
                {
                    await DisplayAlert("Erreur", "La mise à jour a échoué", "OK");
                }
                else
                {
                    Constantes.CurrentUser = result;
                    await DisplayAlert("Succès", "Votre compte a été mis à jour avec succès", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
            }
        }


    }
}
