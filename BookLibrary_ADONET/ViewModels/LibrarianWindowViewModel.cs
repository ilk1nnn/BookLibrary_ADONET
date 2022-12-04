using BookLibrary_ADONET.Commmands;
using BookLibrary_ADONET.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_ADONET.ViewModels
{
    public class LibrarianWindowViewModel
    {
        public LibrarianWindow libwindow { get; set; }

        public RelayCommand ShowAllBooksCommand { get; set; }
        public RelayCommand DeleteBookCommand { get; set; }
        public RelayCommand UpdateBookCommand { get; set; }
        public RelayCommand InsertNewBookCommand { get; set; }

        public LibrarianWindowViewModel()
        {
            ShowAllBooksCommand = new RelayCommand(s =>
            {
                var showall = new ShowAllBooksWindow();
                showall.Show();
                libwindow.Close();
            });



        }

    }
}
