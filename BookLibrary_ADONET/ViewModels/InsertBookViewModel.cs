﻿using BookLibrary_ADONET.Abstractions;
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
    public class InsertBookViewModel : BaseViewModel
    {

        private IRepository<Book> _bookRepo;

        public TextBox idtxtb { get; set; }
        public TextBox nametxtb { get; set; }
        public TextBox pagestxtb { get; set; }
        public TextBox quantitytxtb { get; set; }

        private LibraryDbDataContext _dataContext;

        private ObservableCollection<Book> allBooks;

        public ObservableCollection<Book> AllBooks
        {
            get { return allBooks; }
            set { allBooks = value; OnPropertyChanged(); }
        }
        public RelayCommand InsertCommand { get; set; }

        public InsertBookViewModel(IRepository<Book> bookRepo)
        {
            _bookRepo= bookRepo;


            InsertCommand = new RelayCommand(i =>
            {
                int id = int.Parse(idtxtb.Text);
                int pages = int.Parse(pagestxtb.Text);
                int quantity = int.Parse(quantitytxtb.Text);
                AllBooks = _bookRepo.GetAllData();
                Book book = new Book
                {
                    Id = id,
                    Name= nametxtb.Text,
                    Pages=pages,
                    Quantity=quantity
                };
                _bookRepo.AddData(book);
                var show_window = new ShowAllBooksWindow();
                show_window.Show();
                MessageBox.Show($@"{nametxtb.Text} ADDED Successfully");
            });



        }



    }
}
