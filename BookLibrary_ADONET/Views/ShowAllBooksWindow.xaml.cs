using BookLibrary_ADONET.Abstractions;
using BookLibrary_ADONET.DataAccess;
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

namespace BookLibrary_ADONET.ViewModels
{
    /// <summary>
    /// Interaction logic for ShowAllBooksWindow.xaml
    /// </summary>
    public partial class ShowAllBooksWindow : Window
    {

        public ShowAllBooksWindow()
        {
            InitializeComponent();
            var bookRepo = new BookRepository();
            var showallviewmodel = new ShowAllBooksViewModel(bookRepo);
            this.DataContext = showallviewmodel;
        }
    }
}
