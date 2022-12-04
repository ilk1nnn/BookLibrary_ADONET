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
    /// Interaction logic for InsertNewBookWindow.xaml
    /// </summary>
    public partial class InsertNewBookWindow : Window
    {
        public InsertNewBookWindow()
        {
            InitializeComponent();
            var bookRepo = new BookRepository();
            var v = new InsertBookViewModel(bookRepo);
            v.idtxtb = IdTxtb;
            v.pagestxtb = PagesTxtb;
            v.quantitytxtb = QuantityTxtb;
            v.nametxtb = NameTxtb;
            this.DataContext = v;
        }
    }
}
