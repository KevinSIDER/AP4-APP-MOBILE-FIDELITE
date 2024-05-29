using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class CreateRewardVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public CreateRewardVue()
        {
            InitializeComponent();
        }

        private async void OnCreateReward(object sender, EventArgs e)
        {
            Reward rewardData = new Reward();
            rewardData.ID = Constantes.CurrentUser.Id;
            rewardData.NomRecompense = NomRecompense.Text;
            rewardData.PointsNecessaires = int.Parse(PointsNecessaires.Text);
            rewardData.LeProduit = int.Parse(LeProduit.Text);

            var result = await _apiServices.GetOneAsync("api/mobile/creerRecompense", rewardData);
            if (result == null)
            {
                await DisplayAlert("Erreur", "La r�compense n'a pas �t� cr��", "OK");
            }
            else
            {
                await DisplayAlert("C'est bon !", "La r�compense a �t� cr��", "OK");
            }
        }
    }
}