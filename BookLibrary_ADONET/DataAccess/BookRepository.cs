using BookLibrary_ADONET.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_ADONET.DataAccess
{
    public class BookRepository : IBookRepository
    {
        private LibraryDbDataContext _dataContext;

        public BookRepository()
        {
            _dataContext = new LibraryDbDataContext();
        }

        public void AddData(Book data)
        {
            _dataContext.Books.InsertOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public void DeleteData(Book data)
        {
            _dataContext.Books.DeleteOnSubmit(data);
            _dataContext.SubmitChanges();
        }

        public ObservableCollection<Book> GetAllData()
        {
            var books = from b in _dataContext.Books
                        select b;
            return new ObservableCollection<Book>(books);
        }

        public Book GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Book data)
        {
            var item = _dataContext.Books.SingleOrDefault(b => b.Id == data.Id);
            item = new Book
            {
                Id = data.Id,
                Name = data.Name,
                Pages= data.Pages,
                Quantity=data.Quantity
            };

            _dataContext.SubmitChanges();
        }
    }
}
