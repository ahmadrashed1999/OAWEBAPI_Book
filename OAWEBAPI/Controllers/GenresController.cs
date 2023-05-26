using Microsoft.AspNetCore.Mvc;

using OAWEBAPI.Core.Entities;
using OAWEBAPI.Core.Interfaces;
namespace OAWEBAPI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenresController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;

        public GenresController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        [HttpGet]
        public IActionResult GetAllGenres()
        {
            var genres = _genreRepository.GetAll();
            return Ok(genres);
        }

        // Additional actions for handling genre-related operations
    }
}
