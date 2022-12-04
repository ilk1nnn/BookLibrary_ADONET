using BookLibrary_ADONET.Abstractions;
using BookLibrary_ADONET.Commmands;
using BookLibrary_ADONET.DataAccess;
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
    public class DeleteBookViewModel : BaseViewModel
    {
        public RelayCommand DeleteCommand { get; set; }
        public TextBox   IDTxtb { get; set; }

        private readonly IRepository<Book> _bookRepo;

        private  LibraryDbDataContext _dataContext;

        private ObservableCollection<Book> allBooks;

        public ObservableCollection<Book> AllBooks
        {
            get { return allBooks; }
            set { allBooks = value; OnPropertyChanged(); }
        }


        public DeleteBookViewModel(IRepository<Book> bookRepo)
        {
            _bookRepo = bookRepo;

            DeleteCommand = new RelayCommand(d =>
            {
                int id = int.Parse(IDTxtb.Text);
                AllBooks = _bookRepo.GetAllData();
                var bo = AllBooks.Where(b => b.Id == id).First();
                _bookRepo.DeleteData(bo);
                var show_window = new ShowAllBooksWindow();
                show_window.Show();
                MessageBox.Show("Deleted Successfully");
            });
        }


    }
}
