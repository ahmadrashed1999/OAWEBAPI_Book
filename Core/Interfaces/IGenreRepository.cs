using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using OAWEBAPI.Core.Entities;

namespace OAWEBAPI.Core.Interfaces
{
    public interface IGenreRepository
    {
        Genre GetById(int id);
        IEnumerable<Genre> GetAll();
        void Add(Genre genre);
        void Update(Genre genre);
        void Delete(Genre genre);

        IEnumerable<Genre> SearchGenres(string keyword);
        IEnumerable<Genre> GetGenresByCriteria(string criteria);
        IEnumerable<Genre> GetGenresWithBooks();
        IEnumerable<Genre> GetGenresWithPagination(int page, int pageSize);
    }
}