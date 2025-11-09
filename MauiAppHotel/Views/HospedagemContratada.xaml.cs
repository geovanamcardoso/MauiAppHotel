namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try 
		{
			Navigation.PopAsync(); //volta para a página anterior
        }
		catch (Exception ex) 
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}

    }
}