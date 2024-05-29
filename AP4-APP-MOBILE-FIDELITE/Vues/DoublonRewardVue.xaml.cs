using System;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class DoublonRewardVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();
        private ObservableCollection<Reward> result = new ObservableCollection<Reward>();

        public DoublonRewardVue()
        {
            InitializeComponent();
        }

        private async void Button_GetAllRewardUtilisees(object sender, EventArgs e)
        {
            // M�thode pour voir si il y a des doublons dans la table "R�compense" d'apr�s le nom de la r�compense
            try
            {
                // API
                var result = await _apiServices.GetAllAsyncByID<Reward>("api/mobile/recompensesUtilisees", "Id", Constantes.CurrentUser.Id);

                var listeReward = JsonConvert.DeserializeObject<List<Reward>>(JsonConvert.SerializeObject(result)); // Dezerializer valeur vers

                // Stocker les noms de r�compeses avec ma liste
                var valeurDoublon = new List<string>();

                var nbrDoublon = 0;

                foreach (var reward in listeReward) // Je parcours ma liste et chaque �l�ment c'est reward
                {
                    var nomRecompense = reward.NomRecompense;

                    if (valeurDoublon.Contains(nomRecompense))
                    {
                        nbrDoublon++; // J'incr�mente mon compteur
                    }
                    else
                    {
                        valeurDoublon.Add(nomRecompense);
                    }
                }

                // Affichage r�sultat
                if (nbrDoublon > 0)
                {
                    await DisplayAlert("Doublon", $"Il y a {nbrDoublon} doublons", "Ok");
                }
                else
                {
                    await DisplayAlert("Pas doublon", "0", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
            }
        }
    }
}