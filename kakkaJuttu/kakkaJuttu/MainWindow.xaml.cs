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
using System.Threading;

namespace kakkaJuttu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pläm = 100;
        int i = 10;
        int j = 20;
        int k = 30;
        int l = 50;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string tiedosto = @"D:\Code\lämpötila.txt";

            //Luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {

                int lämpötila = 0;
                string syöte = textBox.Text;
                lämpötila = int.Parse(syöte);


                //Tiedostoon kirjoittaminen
                File.WriteAllText(tiedosto, lämpötila.ToString());
                MessageBox.Show("Lämpötila tallennettu.");

                textBox.Text = string.Empty;
                tekstiBox.Text = "Lämpö asetettu onnistuneesti!";         
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string tiedosto = @"D:\Code\lämpötila.txt";

            if (File.Exists(tiedosto))
            {

                string aiempiArvo = File.ReadAllText(tiedosto);
                textBox.Text = (aiempiArvo);
                Thread.Sleep(1500);
                tekstiBox.Text = "Arvo haettu onnistuneesti!";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            pläm = l;
            textBox.Text = (pläm).ToString();
            tekstiBox.Text = "Arvo 50 syötettetty!";
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            tekstiBox.Text = "Arvo 10 ehdoitettu!";
            pläm = i;
            textBox.Text = (pläm).ToString();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            tekstiBox.Text = "Arvo 20 ehdoitettu!!";
            pläm = j;
            textBox.Text = (pläm).ToString();
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            tekstiBox.Text = "Arvo 30 ehdoitettu!";
            pläm = k;
            textBox.Text = (pläm).ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = (++pläm).ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = (--pläm).ToString();
        }
    }
}
