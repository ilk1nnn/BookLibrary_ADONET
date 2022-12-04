using BookLibrary_ADONET.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_ADONET.Abstractions
{
    public interface IBookRepository : IRepository<Book>
    {
    }
}
