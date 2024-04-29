using System.Text.Json;


namespace PatyTempo;


public partial class MainPage : ContentPage
{
        const string Url="https://api.hgbrasil.com/weather?woeid=455927&key=73874c1b";    
        Resposta resposta;
        public MainPage()
        {

                InitializeComponent();
                AtualizaTempo();

        }

	void PreencherTela()
        {
                labelTemp.Text= resposta.results.temp.ToString();
                labelSky.Text= resposta.results.description;
                labelCidade.Text= resposta.results.city;
                labelChuva.Text= resposta.results.rain.ToString();
                labelHumidade.Text= resposta.results.humidity.ToString();
                labelAmanhecer.Text=  resposta.results.sunrise;
                labelAnoitecer.Text=  resposta.results.sunset;
                labelForcawind.Text=  resposta.results.wind_speedy.ToString();
                labelDirecaowind.Text=  resposta.results.wind_direction.ToString();
                labelMoonFase.Text=  resposta.results.moon_phase;

                if (resposta.results.currently =="dia")
                {
                        if (resposta.results.rain >=10)
                                fotodefundo.Source="diachuvoso.jpg";
                        else if (resposta.results.cloudiness >=10)
                                fotodefundo.Source="dianublado.jpg";
                        else
                                fotodefundo.Source="diaensolarado.jpg";
                }
                else               
                {
                        if (resposta.results.rain >=10)
                                fotodefundo.Source="noitechuvosa.avif";
                        else if (resposta.results.cloudiness >=10)
                                fotodefundo.Source="noitenublado.jpg";
                        else
                                fotodefundo.Source="ceuestrelado.jpg";
                }
        }

        async void AtualizaTempo()
        {
                try 
                {
                        var httpCliente = new HttpClient();
                        var response = await httpCliente.GetAsync(Url);
                        if (response.IsSuccessStatusCode)
                        {
                        var content = await response.Content.ReadAsStringAsync();
                        resposta = JsonSerializer.Deserialize<Resposta>(content);
                        }
                        PreencherTela();
                }
                catch (Exception e)
                {
                        System.Diagnostics.Debug.WriteLine(e);
                }
        }
   }
