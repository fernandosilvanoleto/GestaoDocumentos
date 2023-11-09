using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Controllers
{
    public class BibliotecarioController : Controller
    {
        private readonly IBibliotecarioRepository _bibliotecarioRepository;
        public BibliotecarioController(IBibliotecarioRepository bibliotecarioRepository)
        {
            _bibliotecarioRepository = bibliotecarioRepository;
        }
        public IActionResult Index(int? todosBibliotecarios)
        {
            List<BibliotecarioModel> bibliotecarios;

            if (todosBibliotecarios == 1)
            {
                bibliotecarios = _bibliotecarioRepository.BuscarTodosBibliotecarios();
            }
            else
            {
                bibliotecarios = _bibliotecarioRepository.BuscarBibliotecarioAtivos();
            }

            return View(bibliotecarios);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(BibliotecarioModel bibliotecarioModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bibliotecarioRepository.AdicionarBibliotecario(bibliotecarioModel);

                    TempData["MensagemSucesso"] = "Bibliotecário cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(bibliotecarioModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Bibliotecário não cadastrado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            if (id > 0)
            {
                var bibliotecario = _bibliotecarioRepository.ListarPorIdBibliotecario(id);
                if (bibliotecario != null)
                {
                    return View(bibliotecario);
                }
                else
                {
                    throw new System.Exception("Houve um erro ao buscar bibliotecário na base de dados!");
                }
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult Editar(BibliotecarioModel bibliotecarioModel)
        {
            try
            {
                if (ModelState.IsValid && bibliotecarioModel != null)
                {
                    _bibliotecarioRepository.EditarBibliotecario(bibliotecarioModel);

                    TempData["MensagemSucesso"] = "Bibliotecário atualizado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", bibliotecarioModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! Bibliotecário não atualizado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Remover(int id)
        {
            if (id > 0)
            {
                var bibliotecario = _bibliotecarioRepository.ListarPorIdBibliotecario(id);

                if (bibliotecario != null)
                {
                    return View(bibliotecario);
                }
            }

            return View("Index");
        }

        public IActionResult RemoverBibliotecario(int id)
        {
            try
            {
                if (id > 0)
                {
                    bool removido = _bibliotecarioRepository.RemoverBibliotecario(id);

                    if (removido)
                    {
                        TempData["MensagemSucesso"] = "Bibliotecário excluído com sucesso";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops! Não conseguimos excluir o Bibliotecário. Tente novamente mais tarde!";
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! O Bibliotecário não foi excluído com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult AtivarBibliotecario(int id)
        {
            try
            {
                if (id > 0)
                {
                    bool removido = _bibliotecarioRepository.AtivarBibliotecario(id);

                    if (removido)
                    {
                        TempData["MensagemSucesso"] = "Bibliotecário reativado com sucesso";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops! Não conseguimos reativar o Bibliotecário. Tente novamente mais tarde!";
                    }
                }

                return RedirectToAction("IndexTodosBibliotecarios");
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! O Bibliotecário não foi reativado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
