using System.Collections.ObjectModel;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using AP4_APP_MOBILE_FIDELITE.Vues;

namespace AP4_APP_MOBILE_FIDELITE.Vues;

public partial class CreatorModeVue : ContentPage
{
    public CreatorModeVue()
    {
        InitializeComponent();
    }

    private async void GoCreateCommande(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateCommandeVue());
    }

    private async void GoCreateProduct(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateProductVue());
    }
    private async void GoCreateCategorie(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateCategorieVue());
    }

    private async void GoCreateBlason(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateBlasonVue());
    }

    private async void GoCreateReward(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateRewardVue());
    }
}