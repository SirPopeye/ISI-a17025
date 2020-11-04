/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using ClassLibrary;
using Ficha_de_Exercicios_IPMA___3.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Ficha_de_Exercicios_IPMA___3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Dictionary<string, int> dicLocais;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads Loacais and converts to type Dictionary<string, int>.
        /// </summary>
        /// <returns></returns>
        private static async Task<Dictionary<string, int>> LoadLocalInfo()
        {
            var locais = await LocalProcessor.LoadLocais();

            return locais.GroupBy(l => l.local).ToDictionary(k => k.Key, v => v.Select(f => f.globalIdLocal).First());
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Loads Locais.
            dicLocais = await LoadLocalInfo();
            LocaisComboBox.ItemsSource = dicLocais;
        }

        /// <summary>
        /// Loads weather forecast info, finds extra values and calls functions to write info on json file.
        /// (tmed, amplitudetermica, temperaturaMinimaSemanal, temperaturaMaximaSemanal)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var local = LocaisComboBox.SelectedValue.ToString();
            var globalID = dicLocais[local];

            PrevisaoIpmaModel currentPrevisao = await PrevisaoProcessor.LoadPrevisoes(globalID);

            PrevisaoIpma previsaoIpma = JsonConvert.DeserializeObject<PrevisaoIpma>(JsonConvert.SerializeObject(currentPrevisao));
            previsaoIpma.local = local;

            int index = 0;
            float maxTemp = -999, minTemp = 999; 

            foreach (PrevisaoDiaModel pDiaModel in currentPrevisao.data)
            {
                float tmin = float.Parse(pDiaModel.tMin, CultureInfo.InvariantCulture.NumberFormat);  
                float tmax = float.Parse(pDiaModel.tMax, CultureInfo.InvariantCulture.NumberFormat);

                previsaoIpma.data[index].temperatura.tmax = tmax;
                previsaoIpma.data[index].temperatura.tmin = tmin;
                previsaoIpma.data[index].temperatura.tmedia = ((tmax + tmin) / 2);

                if (tmax > maxTemp) maxTemp = tmax;
                if (tmin < minTemp) minTemp = tmin;

                //Writes Files
                WriteFiles1Day(previsaoIpma.data[index], previsaoIpma.local);

                index ++;
            }

            previsaoIpma.amplitudeTermica = maxTemp - minTemp;
            previsaoIpma.temperaturaMinimaSemanal = minTemp;
            previsaoIpma.temperaturaMaximaSemanal = maxTemp;
            previsaoIpma.local = local;

            UpdateUI(previsaoIpma);

            WriteFiles5Day(previsaoIpma);
        }

        /// <summary>
        /// Updates UI with correct Values.
        /// </summary>
        /// <param name="previsaoIpma"></param>
        private void UpdateUI(PrevisaoIpma previsaoIpma)
        {
            var TempTextBoxMin = new[] { TminD1, TminD2, TminD3, TminD4, TminD5 };
            var TempTextBoxMax = new[] { TmaxD1, TmaxD2, TmaxD3, TmaxD4, TmaxD5 };
            var DateTextBox = new[] { DateD1, DateD2, DateD3, DateD4, DateD5 };
            var Images = new[] { ImageD1, ImageD2, ImageD3, ImageD4, ImageD5 };

            int index = 0; 
            foreach(PrevisaoDia pd in previsaoIpma.data)
            {
                TempTextBoxMin[index].Text = pd.temperatura.tmin.ToString() + "ºC  ";
                TempTextBoxMax[index].Text = pd.temperatura.tmax.ToString() + "ºC  ";
                DateTextBox[index].Text = pd.forecastDate;

                LoadImage(WeatherImages.GetCode(pd.idWeatherType), Images[index]);
                
                index++;
            }
        }

        /// <summary>
        /// Loads Image correspondent with weather ID.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        private void LoadImage(string code, Image img)
        {
            if (!(code == "-1"))
            {
                var uriSource = new Uri($"http://openweathermap.org/img/wn/{code}d@2x.png", UriKind.Absolute);
                img.Source = new BitmapImage(uriSource);
            }
            else
            {
                throw new Exception("Invalid Weather Type Code.");
            }
        }

        /// <summary>
        /// Writes File of 5 day weather forecast.
        /// </summary>
        /// <param name="currentPrevisao"></param>
        private static void WriteFiles5Day(PrevisaoIpma currentPrevisao)
        {
            // Writes json File
            using (StreamWriter file = File.CreateText($@"./output/{currentPrevisao.globalIdLocal}-detalhe.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, currentPrevisao);
            }
        }

        /// <summary>
        /// Writes File of 1 day weather forecast.
        /// </summary>
        /// <param name="previsaoDia"></param>
        /// <param name="local"></param>
        private static void WriteFiles1Day(PrevisaoDia previsaoDia, string local)
        {
            // Writes json File
            using (StreamWriter file = File.CreateText($@"./output/{local}-{previsaoDia.forecastDate}.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, previsaoDia);
            }
        }

        /// <summary>
        /// Generates File with weather forecast for the entire country for the present date. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PrevisaoDiaPais previsaoDiaPais = new PrevisaoDiaPais();

            foreach(KeyValuePair<string, int> kv in dicLocais)
            {
                PrevisaoIpmaModel currentPrevisao = await PrevisaoProcessor.LoadPrevisoes(kv.Value);

                PrevisaoIpma previsaoIpma = JsonConvert.DeserializeObject<PrevisaoIpma>(JsonConvert.SerializeObject(currentPrevisao));

                previsaoIpma.data[0].temperatura.tmax = float.Parse(currentPrevisao.data[0].tMax, CultureInfo.InvariantCulture.NumberFormat); ;
                previsaoIpma.data[0].temperatura.tmin = float.Parse(currentPrevisao.data[0].tMin, CultureInfo.InvariantCulture.NumberFormat);
                previsaoIpma.data[0].temperatura.tmedia = ((previsaoIpma.data[0].temperatura.tmax + previsaoIpma.data[0].temperatura.tmin) / 2);

                previsaoIpma.data[0].local = kv.Key;
                previsaoDiaPais.data.Add(previsaoIpma.data[0]);
            }

            WriteFilesDayCountry(previsaoDiaPais);
        }

        /// <summary>
        /// Writes file with weather forecast for the entire country for today.
        /// </summary>
        /// <param name="previsaoDiaPais"></param>
        private static void WriteFilesDayCountry(PrevisaoDiaPais previsaoDiaPais)
        {
            // Writes json File
            using (StreamWriter file = File.CreateText($@"./output/Pais-{previsaoDiaPais.data[0].forecastDate}.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, previsaoDiaPais);
            }
        }
    }
}
