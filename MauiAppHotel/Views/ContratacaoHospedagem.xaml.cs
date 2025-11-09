namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();


        //Serve para ter acesso as propriedades criadas na classe App.xaml.cs
        PropriedadesApp = (App)Application.Current;

        //Definir o ItemSource do Picker com a lista de quartos
        pck_quarto.ItemsSource = PropriedadesApp.Lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
    }

    private async void OnBtnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Sobre());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {   //Método que me permite navegar para a próxima página
            Navigation.PushAsync(new HospedagemContratada()); 
        }
        catch (Exception ex) 
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_checkin = elemento.Date;
        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}