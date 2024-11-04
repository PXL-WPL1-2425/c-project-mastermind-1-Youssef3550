using System;
using System.Collections.Generic;
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

namespace mastermind_Mahtar_Youssef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RandomKleuren();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RandomKleuren()
        {
            Random random = new Random();
            List<string> kleuren = new List<string> { "rood", "geel", "oranje", "wit", "groen", "blauw" };

            List<string> code = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                string randomKleur = kleuren[random.Next(kleuren.Count)];
                code.Add(randomKleur);
            }

            string codeString = string.Join(", ", code);

            this.Title = $"Mastermind ({codeString})"; 
        }
    }
}
