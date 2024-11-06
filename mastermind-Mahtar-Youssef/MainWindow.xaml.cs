using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
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

            
            foreach (string kleur in kleuren)
            {
                ComboBox1.Items.Add(kleur);
                ComboBox2.Items.Add(kleur);
                ComboBox3.Items.Add(kleur);
                ComboBox4.Items.Add(kleur);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            
            string kleurCode = GeklozenKleuren(comboBox);
            SolidColorBrush colorBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(kleurCode);

           
            if (comboBox == ComboBox1)
            {
                Label1.Background = colorBrush;
            }
            else if (comboBox == ComboBox2)
            {
                Label2.Background = colorBrush;
            }
            else if (comboBox == ComboBox3)
            {
                Label3.Background = colorBrush;
            }
            else if (comboBox == ComboBox4)
            {
                Label4.Background = colorBrush;
            }
        }

        private string GeklozenKleuren(ComboBox comboBox)
        {
                if (comboBox != null && comboBox.SelectedItem is string gekozenKleur)
            {
                
                switch (gekozenKleur.ToLower())
                {
                    case "rood":
                        return "#FF0000"; 
                    case "groen":
                        return "#008000"; 
                    case "blauw":
                        return "#0000FF"; 
                    case "geel":
                        return "#FFFF00"; 
                    case "oranje":
                        return "#FFA500"; 
                    case "wit":
                        return "#FFFFFF"; 
                    default:
                        return "#D3D3D3"; 
                }
            }

            return "#D3D3D3"; // Kleurcode "LIGHTGRAY". Is hetzelfde als achtergrond voor de kleur wit te kunnen testen.
        }
    }
}
