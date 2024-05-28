using System;
using AP4_APP_MOBILE_FIDELITE.Api;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using System.Collections.ObjectModel;

namespace AP4_APP_MOBILE_FIDELITE.Vues
{
    public partial class GetAllBlasonsVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();
        private ObservableCollection<Blason> result = new ObservableCollection<Blason>();

        public GetAllBlasonsVue()
        {
            InitializeComponent();
        }

        private async void Button_GetAllBlasons(object sender, EventArgs e)
        {
            try
            {
                result = await _apiServices.GetAllAsync<Blason>("api/mobile/GetAllBlasons");
                MalisteProduit.ItemsSource = result;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
            }
        }
    }
}