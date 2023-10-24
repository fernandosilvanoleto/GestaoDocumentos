using GestaoDocumentos.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoRepository _emprestimoRepository;

        public EmprestimoController(IEmprestimoRepository emprestimoRepository)
        {
            _emprestimoRepository = emprestimoRepository;
        }
        public IActionResult Index()
        {
            var emprestimos = _emprestimoRepository.BuscarTodosEmprestimosAtivos();

            return View(emprestimos);
        }
    }
}
