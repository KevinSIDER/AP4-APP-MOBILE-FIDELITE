

using System.Collections.ObjectModel;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using AP4_APP_MOBILE_FIDELITE.Vues;

namespace AP4_APP_MOBILE_FIDELITE.Vues;

public partial class AccueilVue : ContentPage
{
    public AccueilVue()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProduitVue()); // Navigate to AccueilPage

    }
}