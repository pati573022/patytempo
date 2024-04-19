namespace PatyTempo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	
    Resultados= new Results();
	PreencherTela()
	}

{voidPreencherTela()
}

 labelTemp.Text= Resultados.temp.Tostring();
 labelSky.Text= Resultados.description;
 labelCidade.Text= Resultados.city;
 labelChuva.Text= Resultados.rain.Tostring();
 labelHumidade.Text= Resultados.humidity.Tostring();



