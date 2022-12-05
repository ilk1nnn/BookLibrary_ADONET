using BookLibrary_ADONET.Abstractions;
using BookLibrary_ADONET.Commmands;
using BookLibrary_ADONET.DataAccess;
using BookLibrary_ADONET.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookLibrary_ADONET.ViewModels
{
    public class LibrarianWindowViewModel : BaseViewModel
    {
        public LibrarianWindow libwindow { get; set; }
        private IRepository<Book> _bookRepo;


        private LibraryDbDataContext _dataContext;

        private ObservableCollection<Book> allBooks;

        public ObservableCollection<Book> AllBooks
        {
            get { return allBooks; }
            set { allBooks = value; OnPropertyChanged(); }
        }

        public RelayCommand ShowAllBooksCommand { get; set; }
        public RelayCommand DeleteBookCommand { get; set; }
        public RelayCommand UpdateBookCommand { get; set; }
        public RelayCommand InsertNewBookCommand { get; set; }

        public TextBox idtxtb { get; set; }
        public TextBox nametxtb { get; set; }
        public TextBox pagestxtb { get; set; }
        public TextBox quantitytxtb { get; set; }

        public LibrarianWindowViewModel(IRepository<Book> bookRepo)
        {
            _bookRepo = bookRepo;

            ShowAllBooksCommand = new RelayCommand(s =>
            {
                var showall = new ShowAllBooksWindow();
                showall.Show();
                libwindow.Close();
            });

            DeleteBookCommand = new RelayCommand(d =>
            {
                var deletebook = new DeleteBookWindow();
                deletebook.Show();
                libwindow.Close();
            });

            InsertNewBookCommand = new RelayCommand(d =>
            {
                var insertbook = new InsertNewBookWindow(); 
                insertbook.Show();
                libwindow.Close();
            });

            UpdateBookCommand = new RelayCommand(u =>
            {

                int id = 2;
                int pages = 20000;
                int quantity = 100;
                Book book = new Book
                {
                    Id = id,
                    Pages = pages,
                    Quantity = quantity,
                    Name = "Hello World Book",
                    YearPress = 2001,
                    Id_Themes = 1,
                    Id_Author = 1,
                    Id_Category = 1,
                    Id_Press = 1,
                    Comment = "Good Kitab"
                };
                _bookRepo.UpdateData(book);
               
                MessageBox.Show($@"Hello World Book Updated Successfully");
            });

        }

    }
}
