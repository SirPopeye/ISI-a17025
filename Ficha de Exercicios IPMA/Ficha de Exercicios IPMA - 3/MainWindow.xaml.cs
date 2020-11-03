using ClassLibrary;
using Ficha_de_Exercicios_IPMA___3.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private static async Task<Dictionary<string, int>> LoadLocalInfo()
        {
            var locais = await LocalProcessor.LoadLocais();

            return locais.GroupBy(l => l.local).ToDictionary(k => k.Key, v => v.Select(f => f.globalIdLocal).First());
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dicLocais = await LoadLocalInfo();
            LocaisComboBox.ItemsSource = dicLocais;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var local = LocaisComboBox.SelectedValue.ToString();
            var globalID = dicLocais[local];

            PrevisaoIpmaModel currentPrevisao = await PrevisaoProcessor.LoadPrevisoes(globalID);

            PrevisaoIpma previsaoIpma = JsonConvert.DeserializeObject<PrevisaoIpma>(JsonConvert.SerializeObject(currentPrevisao));

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

                index ++;
            }

            previsaoIpma.amplitudeTermica = maxTemp - minTemp;
            previsaoIpma.temperaturaMinima = minTemp;
            previsaoIpma.temperaturaMaxima = maxTemp;
            previsaoIpma.local = local;

            UpdateUI(previsaoIpma);
        }

        /// <summary>
        /// Updates UI with correct Values.
        /// </summary>
        /// <param name="previsaoIpma"></param>
        private async void UpdateUI(PrevisaoIpma previsaoIpma)
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

                //var code = GetCode(pd.idWeatherType);
                //Console.WriteLine(pd.idWeatherType +" <-> " + code);
                await LoadImage(GetCode(pd.idWeatherType), Images[index]);
                
                index++;
            }
        }

        private async Task LoadImage(string code, Image img)
        {
            if (!(code == "-1"))
            {
                var uriSource = new Uri($"http://openweathermap.org/img/wn/{code}d@2x.png", UriKind.Absolute);
                img.Source = new BitmapImage(uriSource);
            }
        }

        private string GetCode(int id)
        {
            if (id == 1) return "01";
            if (id == 2 || id == 3) return "02";
            if (id == 4) return "03";
            if (id == 5 || id == 24 || id == 25 || id == 27) return "04";
            if (id == 6 || id == 8 || id == 9 || id == 11 || id == 14) return "09";
            if (id == 7 || id == 10 || id == 12 || id == 13 || id == 15) return "10";
            if (id == 19 || id == 20 || id == 23) return "11";
            if (id == 18 || id == 21 || id == 22) return "13";
            if (id == 16 || id == 17 || id == 26) return "50";
            return "-1";
        }
    }
}
