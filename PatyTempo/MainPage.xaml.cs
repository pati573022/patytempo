using System.Text.Json;
using Windows.Storage;

namespace PatyTempo;

public partial class MainPage : ContentPage
{
    Results Resultados = new Results();
	public MainPage()
	{

	InitializeComponent();
	AtualizaTempo();

	}

	void PreencherTela()
{
     labelTemp.Text= Resultados.temp.ToString();
     labelSky.Text= Resultados.description;
     labelCidade.Text= Resultados.city;
     labelChuva.Text= Resultados.rain.ToString();
     labelHumidade.Text= Resultados.humidity.ToString();
     labelAmanhecer.text= Resultados.sunrise;
     labelAnoitecer.Text= Resultados.sunset;
     labelForcawind.Text= Resultados.wind_speedy.ToString();
     labelDirecaowind.Text= Resultados.wind_direction;
     labelMoonFase.Text= Resultados.moon_phase;
 }
async void AtualizaTempo()
{
        try 
{
   var httpCliente = new HttpClient();
   var response = await httpCliente.GetAsync(Ur1);
   if (response.IsSuccessStatusCode)
   {
        var content = await response.Content.ReadAsStringAsync();
        Resposta = JsonSerializer.Deserialize<Resposta>(content);
   }
   PreencherTela();
}
catch (Exception e)
{
System.Diagnostics.Debug.WriteLine(e);
}
}
}






}


        var httpCliente = new Http





}






}