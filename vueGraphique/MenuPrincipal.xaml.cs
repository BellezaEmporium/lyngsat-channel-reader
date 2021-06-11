using Metier;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace vueGraphique
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    Channels.ItemsSource = null;
                    Channels.ItemsSource = Controller.ReadFile(Path.GetFullPath(filename));
                }
            }
        }
    }
}
