using System;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class GetAllRecompensesVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();
        private ObservableCollection<Reward> result = new ObservableCollection<Reward>();

        public GetAllRecompensesVue()
        {
            InitializeComponent();
        }

        private async void Button_GetAllRecompenses(object sender, EventArgs e)
        {
            try
            {
                string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
                JObject currentUserJson = JObject.Parse(currentUserJsonString);
                int id = (int)currentUserJson["id"];

                var result = await _apiServices.GetAllAsyncByID<Product>("api/mobile/getAllRecompenses", "Id", id);
                MesRecompenses.ItemsSource = result;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
            }
        }
    }
}