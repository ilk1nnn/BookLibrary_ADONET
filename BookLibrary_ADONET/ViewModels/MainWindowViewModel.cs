using BookLibrary_ADONET.Abstractions;
using BookLibrary_ADONET.Commmands;
using BookLibrary_ADONET.DataAccess;
using BookLibrary_ADONET.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookLibrary_ADONET.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public RelayCommand LibrarianCommand { get; set; }
        public RelayCommand StudentCommand { get; set; }

        public MainWindow mainwindow { get; set; }


        public MainWindowViewModel()
        {

            LibrarianCommand = new RelayCommand(l =>
            {
                var lib_window = new LibrarianWindow();
                lib_window.Show();
                mainwindow.Close();
            });

            StudentCommand = new RelayCommand(s =>
            {
                var student_window = new StudentWindow();
                student_window.Show();
                mainwindow.Close();
            });

        }
    }
}
