using System;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class ShowAllProduct : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();
        private ObservableCollection<Product> result = new ObservableCollection<Product>();

        public ShowAllProduct()
        {
            InitializeComponent();
        }

        private async void Button_GetAllProduits(object sender, EventArgs e)
        {
            string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
            JObject currentUserJson = JObject.Parse(currentUserJsonString);
            string id = (string)currentUserJson["id"];
            var result = await _apiServices.GetOneAsync("api/mobile/GetAllProduits", id);
            MesProduits.ItemsSource = result;
            if (result == null) 
            {

                await DisplayAlert("Erreur", result , "OK"); 
            }
        }
    }
}