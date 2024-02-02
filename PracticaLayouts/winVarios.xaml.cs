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
    /// Lógica de interacción para winVarios.xaml
    /// </summary>
    public partial class winVarios : Window
    {
        public winVarios()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (wrapOrienta.Orientation == Orientation.Horizontal)
                wrapOrienta.Orientation = Orientation.Vertical;
            else
                wrapOrienta.Orientation = Orientation.Horizontal;
        }
    }
}
