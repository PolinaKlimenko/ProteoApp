using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Win32;
using pwiz.CLI.cv;
using pwiz.CLI.data;
using pwiz.CLI.msdata;
using pwiz.CLI.analysis;



namespace ProteoApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        public void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            DataContext =
                new ApplicationViewModel(new DialogService(), new mzXMLFileService());
        }
        /*private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "mzXML (*.mzXML)|*.mzXML|mzML (*.mzML)|*.mzML";
            if (openFileDialog.ShowDialog() == true)
                mzXMLEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }*/
           
    }
}
