using BookLibrary_ADONET.Abstractions;
using BookLibrary_ADONET.Commmands;
using BookLibrary_ADONET.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_ADONET.ViewModels
{
    public class StudentWindowViewModel : BaseViewModel
    {

        private readonly IRepository<Book> _bookRepo;

        private ObservableCollection<Book> allBooks;

        public ObservableCollection<Book> AllBooks
        {
            get { return allBooks; }
            set { allBooks = value; OnPropertyChanged(); }
        }



        public RelayCommand ShowAllCommand { get; set; }

        public StudentWindowViewModel(IRepository<Book> bookRepo)
        {
            _bookRepo = bookRepo;

            ShowAllCommand = new RelayCommand(s =>
            {
                AllBooks = _bookRepo.GetAllData();
                var show = new ShowAllBooksWindow();
                show.Show();

            });

        }

    }
}
