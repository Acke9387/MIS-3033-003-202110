using System;
using System.Collections.Generic;
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

namespace WPF_Files
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            string file = txtFilePath.Text;

            if (File.Exists(file) == false)
            {
                MessageBox.Show("Invalid file.  Please enter a valid file and path.");
                txtFilePath.Clear();
                return;
            }

            //Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude
            string[] contents = File.ReadAllLines(file);

            for (int i = 1; i < contents.Length; i++)
            {
                string line = contents[i];
                //      0	         1	   2	    3	    4	    5	       6	7	8	9	10	11
                //1/2/2009 6:17,Product1,1200,Mastercard,carolina,Basildon,England,United Kingdom,1 / 2 / 2009 6:00,1 / 2 / 2009 6:08,51.5,-1.1166667

                string[] pieces = line.Split(",");
                // pieces[0] = "1/2/2009 6:17"
                // pieces[1] = "Product1"
                // pieces[2] = "1200"
                // pieces[3] = "Mastercard"
                // ...
                DateTime tDate = Convert.ToDateTime(pieces[0]);
                string product = pieces[1];
                double price = Convert.ToDouble(pieces[2]);
                string paymentType = pieces[3];
                SalesData s = new SalesData();
                s.Transaction_date = tDate;
                s.Price = price;
                s.Product = product;
                s.Payment_Type = paymentType;

                if (paymentType == "Mastercard" && product == "Product2")
                {
                    lstLines.Items.Add(s);
                }
            }

        }

        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            string file = @"C:\Users\acke9387\Downloads\output.txt";

            string contents = "This is my file.\nThis is another line of my file.";

            File.WriteAllText(file, contents);

            string file2 = @"C:\Users\acke9387\Downloads\output2.txt";

            string[] output = new string[lstLines.Items.Count];
            for (int i = 0; i < lstLines.Items.Count; i++)
            {
                output[i] = (string)lstLines.Items.GetItemAt(i);
            }

            File.WriteAllLines(file2, output);

        }
    }
}
