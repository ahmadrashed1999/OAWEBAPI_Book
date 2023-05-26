using OAWEBAPI.Core.Entities;
using OAWEBAPI.Core.Interfaces;
using OAWEBAPI.Infrastructure;
namespace OAWEBAPI.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _dataContext;

        public BookRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Book GetById(int id)
        {
            return _dataContext.Books.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _dataContext.Books.ToList();
        }

        public void Add(Book book)
        {
            _dataContext.Books.Add(book);
            _dataContext.SaveChanges();
        }

        public void Update(Book book)
        {
            _dataContext.Books.Update(book);
            _dataContext.SaveChanges();
        }

        public void Delete(Book book)
        {
            _dataContext.Books.Remove(book);
            _dataContext.SaveChanges();
        }
    }
}
