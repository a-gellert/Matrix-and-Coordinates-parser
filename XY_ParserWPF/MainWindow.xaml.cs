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
using XY_ParserWPF.com.gellert.parsing;
using XY_ParserWPF.com.gellert.upload;

namespace XY_ParserWPF
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

        private void file_upload(object sender, RoutedEventArgs e)
        {
            FileUpload.ReadFrom(button, textBox);

        }

        private void parsing(object sender, RoutedEventArgs e)
        {
            Parser.Parsing(textBox, textBox1);

        }
    }
}
