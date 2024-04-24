namespace PatyTempo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{

	InitializeComponent();
    Resultados= new results();
	PreencherTela();

	}

	void PreencherTela()
{
     labelTemp.Text= Resultados.temp.Tostring();
     labelSky.Text= Resultados.description;
     labelCidade.Text= Resultados.city;
     labelChuva.Text= Resultados.rain.Tostring();
     labelHumidade.Text= Resultados.humidity.Tostring();
     labelAmanhecer.text= Resultados.sunrise;
     labelAnoitecer.Text= Resultados.sunset;
     labelForcawind.Text= Resultados.wind_speedy.Tostring();
     labelDirecaowind.Text= Resultados.wind_direction;
     labelMoonFase.Text= Resultados.moon_phase;
 }







}