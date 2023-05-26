
using Microsoft.AspNetCore.Mvc;
using OAWEBAPI.Core.Interfaces;
namespace BookStore.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _bookRepository.GetAll();
            return Ok(books);
        }

        // Additional actions
    }
}
