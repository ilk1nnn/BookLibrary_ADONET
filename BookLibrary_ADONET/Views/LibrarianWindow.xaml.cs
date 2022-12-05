using BookLibrary_ADONET.DataAccess;
using BookLibrary_ADONET.ViewModels;
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

namespace BookLibrary_ADONET.Views
{
    /// <summary>
    /// Interaction logic for LibrarianWindow.xaml
    /// </summary>
    public partial class LibrarianWindow : Window
    {
        public LibrarianWindow()
        {
            InitializeComponent();
            var bookRepo = new BookRepository();
            var mw = new LibrarianWindowViewModel(bookRepo);
            mw.libwindow = this;
            this.DataContext = mw;
        }
    }
}
