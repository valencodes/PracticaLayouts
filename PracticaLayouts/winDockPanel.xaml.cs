using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace PracticaLayouts
{
    /// <summary>
    /// Lógica de interacción para winDockPanel.xaml
    /// </summary>
    public partial class winDockPanel : Window
    {
        DirectoryInfo di; //Objeto que representa a archivos o directorios
        string[] imgList; // Array que va a contener lista de imágenes
        int indice = 0;
        public winDockPanel()
        {
            InitializeComponent();
        }

        private void mostrar()
        {
            lbNombre.Content = "Foto de : " + imgList[indice].Split('.')[0];
            //Si pusiéramos imgList[indice] saldría la extensión del archivo de imagen 
            lbNumfoto.Content = indice + 1 + " de " + imgList.Length; // No es 
                                                                      // necesaria la conversión +Convert.ToString(indice); 
            imgMostrar.Source = new BitmapImage(new // Extraemos imágen de archivo y 
                                                    // la asignamos a control image
            Uri(AppDomain.CurrentDomain.BaseDirectory //directorio actual
            + "fotos\\" + imgList[indice], UriKind.Absolute)); //Source propiedad 
                                                               // que indica la imagen en un control image
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            di = new DirectoryInfo(@".\fotos"); //Creación de objeto directorio
            lbNombre.Content = " Visualizador de Fotografías ";
            lbNumfoto.Content = "Total de Fotografías: " + di.GetFiles().Length;//método para obtener lista de archivos
            imgList = new string[di.GetFiles().Length]; //definimos vector con la lista 
                                                        // imágenes y número de archivos del directorio fotos 
            indice = 0;
            foreach (var fi in di.GetFiles())// mientras que hay archivos
            {
                imgList[indice] = fi.Name; // cargamos nombres de imágenes en vector
                 indice++;
            }
            indice = -1; // Necesario para no sobrepasar los límites

        }

        private void btSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (indice < di.GetFiles().Length - 1) // si el índice es menor que el 
            { // nº de archivos
                indice++; // variable global 
                mostrar(); // cargar imagen
            }
        }

        private void btAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (indice > 0) // Si el índice no es el primero 0
            {
                indice--;
                mostrar();
            }
        }
    }
}
