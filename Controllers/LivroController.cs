using GestaoDocumentos.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroRepository _livroRepository;
        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IActionResult Index()
        {
            var livros = _livroRepository.BuscarTodosLivrosAtivos();

            return View(livros);
        }

        public IActionResult IndexTodosLivros()
        {
            var livros = _livroRepository.BuscarTodosLivros();

            return View(livros);
        }
    }
}
