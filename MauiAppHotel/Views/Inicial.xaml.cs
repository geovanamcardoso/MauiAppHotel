namespace MauiAppHotel.Views;

public partial class Inicial : ContentPage
{
	public Inicial()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        {
            try
            {   //Método que me permite navegar para a próxima página
                Navigation.PushAsync(new ContratacaoHospedagem());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}