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

namespace GitTaak1_KLEUR01
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
        private void HoverEffect_MouseEnter(object sender, MouseEventArgs e)
        {
        // achtergrond blauw als muis niet op achtergond is
            Background = new SolidColorBrush(Colors.LightBlue);
        }
        // achtergrond terug zetten als muis weg is
        private void HoverEffect_MouseLeave(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Colors.LightGray);
        }



        private void ColorImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image clickedImage = sender as Image;

            if (clickedImage == ImageGroen)
            {
                KleurCodeTextBox.Text = "#008000"; // Groen
            }
            else if (clickedImage == ImageRood)
            {
                KleurCodeTextBox.Text = "#FF0000"; // Rood
            }
            else if (clickedImage == ImageGeel)
            {
                KleurCodeTextBox.Text = "#FFFF00"; // Geel
            }
            else if (clickedImage == ImageBlauw)
            {
                KleurCodeTextBox.Text = "#0000FF"; // Blauw
            }
        }
    }
}
