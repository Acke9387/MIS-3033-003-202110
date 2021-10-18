using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace JSON_GOT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GOTQuoteAPI> Quotes = new List<GOTQuoteAPI>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {
            GOTQuoteAPI quote;
            string url = "https://got-quotes.herokuapp.com/quotes";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                quote = JsonConvert.DeserializeObject<GOTQuoteAPI>(json);
            }
            txtQuote.Text = quote.quote;
            lblCharacter.Content = quote.character;
            Quotes.Add(quote);
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(Quotes);

            File.WriteAllText("GOT_Quotes.json", json);
            
            //Example for using a new window
            WndExample ex = new WndExample();

            ex.DoSomething();

            ex.Show();
        }
    }
}
