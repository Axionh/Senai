using Chapter_API.Contexts;
using Chapter_API.Controllers;
using Chapter_API.Interfaces;
using Chapter_API.Models;
using Microsoft.IdentityModel.Tokens;

namespace Chapter_API.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ChapterContext _chapterContext;
        public LivroRepository(ChapterContext context)
        {
            _chapterContext = context;
        }
        public List<Livro> Ler()
        {
            return _chapterContext.Livros.ToList();
        }

        public static implicit operator LivroRepository(LivroController v)
        {
            throw new NotImplementedException();
        }
        public void Cadastrar(Livro livro) 
        {
            _chapterContext.Livros.Add(livro);
            _chapterContext.SaveChanges();
        }
    }
}
