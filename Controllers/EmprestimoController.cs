using GestaoDocumentos.Models;
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
        private readonly IClienteRepository _clienteRepository;
        private readonly IBibliotecarioRepository _bibliotecarioRepository;

        public EmprestimoController(IEmprestimoRepository emprestimoRepository, IClienteRepository clienteRepository, IBibliotecarioRepository bibliotecarioRepository)
        {
            _emprestimoRepository = emprestimoRepository;
            _clienteRepository = clienteRepository;
            _bibliotecarioRepository = bibliotecarioRepository;
        }
        public IActionResult Index()
        {
            var emprestimos = _emprestimoRepository.BuscarTodosEmprestimosAtivos();

            return View(emprestimos);
        }

        public IActionResult IndexTodosEmprestimos()
        {
            var emprestimos = _emprestimoRepository.BuscarTodosEmprestimos();

            return View(emprestimos);
        }

        public IActionResult Registrar()
        {
            ViewBag.ListaClientes_EmEmprestimo = _clienteRepository.BuscarTodosClientesAtivos();
            ViewBag.ListaBibliotecarios_EmEmprestimo = _bibliotecarioRepository.BuscarBibliotecarioAtivos();

            return View();
        }

        [HttpPost]
        public IActionResult Registrar(EmprestimoModel emprestimoModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _emprestimoRepository.AdicionarEmprestimo(emprestimoModel);
                    TempData["MensagemSucesso"] = "Empréstmo cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(emprestimoModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Empréstmo não cadastrado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            if (id > 0)
            {
                var emprestimo = _emprestimoRepository.ListaPorIdEmprestimo(id);
                if (emprestimo != null)
                {
                    return View(emprestimo);
                }
                else
                {
                    throw new System.Exception("Houve um erro ao buscar empréstimo na base de dados!");
                }
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult Editar(EmprestimoModel emprestimoModel)
        {
            try
            {
                if (ModelState.IsValid && emprestimoModel != null)
                {
                    _emprestimoRepository.EditarEmprestimo(emprestimoModel);
                    TempData["MensagemSucesso"] = "Empréstimo atualizado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", emprestimoModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! Empréstimo não atualizado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Remover(int id)
        {
            if (id > 0)
            {
                var emprestimo = _emprestimoRepository.ListaPorIdEmprestimo(id);

                if (emprestimo != null)
                {
                    return View(emprestimo);
                }
            }

            return View("Index");
        }

        public IActionResult RemoverCliente(int id, int opcaoStatus)
        {
            try
            {
                if (id > 0 && opcaoStatus > 0)
                {
                    bool removido = _emprestimoRepository.AjustarStatusAtivo(id, opcaoStatus);

                    if (removido)
                    {
                        TempData["MensagemSucesso"] = "Empréstimo alterado com sucesso";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops! Não conseguimos alterar o Empréstimo. Tente novamente mais tarde!";
                    }
                }

                return RedirectToAction("IndexTodosEmprestimos");
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! O Empréstimo não foi excluído com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
