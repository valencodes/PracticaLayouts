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
using System.Windows.Shapes;

namespace PracticaLayouts
{
    /// <summary>
    /// Lógica de interacción para winTabControl.xaml
    /// </summary>
    public partial class winTabControl : Window
    {
        public winTabControl()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rbCochazo.IsChecked = true;
            cbPelis.SelectedIndex = 0;
        }

        private void rbCochazo_Checked(object sender, RoutedEventArgs e)
        {
            // A través de sender averiguamos donde se ha hecho click 
            RadioButton misender = ((RadioButton)sender);
            string laimagen = "";
            switch (misender.Name)
            { // Escogemos la imagen
                case "rbCochazo":
                    laimagen = "audi.jpg";
                    //laimagen = @"cochesypelis\audi.jpg"; //Si está en carpeta así 
                    break;
                case "rbAsequible":
                    laimagen = "jaguar.jpg";
                    break;
                case "rbAceptable":
                    laimagen = "beetle.jpg";
                    break;
            }
            try
            {
                imgCoche.Source = //asignamos archivo de imagen a mostrar 
                new BitmapImage(new Uri(laimagen, UriKind.Relative));
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
