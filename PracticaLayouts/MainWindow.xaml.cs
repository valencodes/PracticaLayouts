﻿using MultiVentana;
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

namespace PracticaLayouts
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btTab_Click(object sender, RoutedEventArgs e)
        {
            Window Tab = new winTabControl();
            Tab.ShowDialog();
        }

        private void btStack_Click(object sender, RoutedEventArgs e)
        {
            Window Wrap = new winVarios();
            Wrap.ShowDialog();
        }

        private void btDock_Click(object sender, RoutedEventArgs e)
        {
            Window Dock = new winDockPanel();
            Dock.ShowDialog();
        }

        private void btSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btAcercade_Click(object sender, RoutedEventArgs e)
        {
            Window Acerca = new vtAcercade();
            Acerca.ShowDialog();
        }

        private void btGrid_Click(object sender, RoutedEventArgs e)
        {
            Window Grid = new winGrid();
            Grid.ShowDialog();
        }
    }
}
