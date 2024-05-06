

using System.Collections.ObjectModel;
using AP4_APP_MOBILE_FIDELITE.Modeles;
using AP4_APP_MOBILE_FIDELITE.Vues;

namespace AP4_APP_MOBILE_FIDELITE.Vues;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void GoCreateProduct(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateProduct());
    }
    private async void GoCreateCategorie(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateCategorie());
    }

    private async void GoUpdateUser(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UpdateUser());
    }

    private async void GoCreateBlason(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateBlason());
    }

    private async void ShowBlasons(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GetAllBlason());
    }

    private async void GoCreateReward(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateReward());
    }
}