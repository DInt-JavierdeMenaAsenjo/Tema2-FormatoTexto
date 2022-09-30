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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azul_RadioButton.IsChecked = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoFormateado_TextBlock.Text = miTexto_TextBox.Text;
        }

        private void cambiaColor(object sender, RoutedEventArgs e)
        {
            if (verde_RadioButton.IsChecked == true)
                textoFormateado_TextBlock.Foreground = Brushes.Green;
            else if (rojo_RadioButton.IsChecked == true)
                textoFormateado_TextBlock.Foreground = Brushes.Red;
            else if (azul_RadioButton.IsChecked == true)
                textoFormateado_TextBlock.Foreground = Brushes.Blue;
        }

        private void cambiaValor(object sender, RoutedEventArgs e)
        {
            if (negrita_CheckBox.IsChecked == true) 
                textoFormateado_TextBlock.FontWeight = FontWeights.Bold;
            else textoFormateado_TextBlock.FontWeight = FontWeights.Normal;

            if (cursiva_CheckBox.IsChecked == true)
                textoFormateado_TextBlock.FontStyle = FontStyles.Italic;
            else textoFormateado_TextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
