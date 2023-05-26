using OAWEBAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OAWEBAPI.Core.Interfaces
{
    public interface IBookRepository
    {
        Book GetById(int id);
        IEnumerable<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}