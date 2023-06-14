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

namespace WPF_Style_Template_Homework {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void RichTextBox_GotFocus(object sender, RoutedEventArgs e) {
            richtext1box.Selection.Select(richtext1box.Document.ContentStart, richtext1box.Document.ContentEnd);
            richtext1box.Selection.Text = " TextBox Multiline";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            richtext1box.Selection.Select(richtext1box.Document.ContentStart, richtext1box.Document.ContentEnd);
            richtext1box.Selection.Text = " TextBox Multiline";
        }
    }
}
