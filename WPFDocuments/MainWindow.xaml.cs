using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.Win32;

namespace WPFDocuments
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_SaveOnClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XAML Files (*.xaml)|*.xaml|RichText Files (*.rtf)|*rtf|AllFiles(*.*)|*.*";
            if (saveFile.ShowDialog() == true)
            {
                TextRange documentTextRange = new TextRange(RichTextBox.Document.ContentStart, RichTextBox.Document.ContentEnd);
                using (FileStream fs = File.Create(saveFile.FileName))
                {
                    if (Path.GetExtension(saveFile.FileName).ToLower()==".rtf")
                    {
                        documentTextRange.Save(fs, DataFormats.Rtf);
                    }
                    else
                    {
                        documentTextRange.Save(fs, DataFormats.Xaml);
                    }

                }
            }
        }

        private void MenuItem_OpenOnClick(object sender, RoutedEventArgs e)
        {
          
        }

        private void MenuItem_NewOnClick(object sender, RoutedEventArgs e)
        {
            RichTextBox.Document = new FlowDocument();
        }

        private void MenuItem_PrintOnClick(object sender, RoutedEventArgs e)
        {
           
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintDocument(((IDocumentPaginatorSource)RichTextBox.Document).DocumentPaginator, "A Flow Document");
            }
        }
    }
}