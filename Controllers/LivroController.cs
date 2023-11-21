using GestaoDocumentos.Models;
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

        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(LivroModel livroModel)
        {
            if (ModelState.IsValid)
            {
                if (livroModel != null)
                {
                    try
                    {
                        livroModel.PrecoUnitario = float.Parse(livroModel.PrecoUnitarioView.Replace(".", ""));
                        _livroRepository.AdicionarLivro(livroModel);

                        TempData["MensagemSucesso"] = "Empréstmo cadastrado com sucesso";
                        return RedirectToAction("Index");
                    }
                    catch (Exception error)
                    {
                        TempData["MensagemErro"] = $"O Livro não foi cadastrado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                        return RedirectToAction("Index");
                    }
                }
            }

            TempData["MensagemErro"] = $"O Livro está vazio ou ocorreu algum erro!";
            return View(livroModel);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            if (id > 0)
            {
                var livro = _livroRepository.LivroPorIdUnico(id);
                if (livro != null)
                {
                    livro.PrecoUnitarioView = livro.PrecoUnitario.ToString();
                    return View(livro);
                }
                else
                {
                    throw new System.Exception("Houve um erro ao buscar empréstimo na base de dados!");
                }
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult Editar(LivroModel livroModel)
        {
            try
            {
                if (ModelState.IsValid && livroModel != null)
                {
                    livroModel.PrecoUnitario = float.Parse(livroModel.PrecoUnitarioView.Replace(".", ""));
                    _livroRepository.EditarLivro(livroModel);

                    TempData["MensagemSucesso"] = "Livro atualizado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", livroModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! Livro não atualizado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult AtualizarStatus(int idLivro, int opcaoStatus)
        {
            if (idLivro >= 0 && opcaoStatus >= 0)
            {
                var livro = _livroRepository.LivroPorIdUnico(idLivro);
                if (livro != null)
                {
                    try
                    {
                        bool atualizado = _livroRepository.AtualizarStatusLivro(livro, opcaoStatus);

                        if (atualizado)
                        {
                            TempData["MensagemSucesso"] = "Status de Livro atualizado com sucesso";
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Status de Livro não atualizado com sucesso";
                            return RedirectToAction("Index");
                        }
                    }
                    catch (Exception error)
                    {
                        TempData["MensagemErro"] = $"Ocorreu um erro interno ao atualizar o status do Livro. Assim, tente novamente. Detalhe do erro: {error.Message}";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    throw new System.Exception("Houve um erro interno ao buscar o livro na base de dados!");
                }
            }
            else
            {
                TempData["MensagemErro"] = $"Ops! Deu um erro ao Atualizar Status do Livro";
                return RedirectToAction("Index");
            }
        }
    }
}
