using Chapter_API.Interfaces;
using Chapter_API.Models;
using Chapter_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _iLivroRepository;
        public LivroController  (ILivroRepository iLivroRepository)
        {
            _iLivroRepository = iLivroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_iLivroRepository.Ler());
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
        }
    }
}
