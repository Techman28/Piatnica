using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace ITMCode.Piatnica.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient _httpClient;

        public MainWindow()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Settings.ApiURL);


            Test().GetAwaiter().GetResult();

        }

        public async Task Test()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("values");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var deseralize = JsonConvert.DeserializeObject<String[]>(result);
                    MessageBox.Show(result);

                }
                else
                {
                    var result = await response.Content.ReadAsStringAsync();
              
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
          
        }
    }
}
