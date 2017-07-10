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

namespace _02_MyFirstControls
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hi, ");
            sb.Append(Name.Text + "! " );
            sb.Append((bool)Male.IsChecked ? " Male" : " Female");
            sb.Append((bool)Desktop.IsChecked ? ", Desktop" : "");
            sb.Append((bool)Labtop.IsChecked ? ", Labtop" : "");
            sb.Append((bool)Tablet.IsChecked ? ", Tablet" : "");
            sb.Append(" Your job is: " + Job.Text);
            MessageBox.Show(sb.ToString());
        }
    }
}
