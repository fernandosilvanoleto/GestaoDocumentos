using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoRepository _emprestimoRepository;
        private readonly IEmprestimoLivroRepository _emprestimoLivroRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IBibliotecarioRepository _bibliotecarioRepository;
        private readonly ILivroRepository _livroRepository;

        public EmprestimoController(IEmprestimoRepository emprestimoRepository, IEmprestimoLivroRepository emprestimoLivroRepository, IClienteRepository clienteRepository, IBibliotecarioRepository bibliotecarioRepository, ILivroRepository livroRepository)
        {
            _emprestimoRepository = emprestimoRepository;
            _emprestimoLivroRepository = emprestimoLivroRepository;
            _clienteRepository = clienteRepository;
            _bibliotecarioRepository = bibliotecarioRepository;
            _livroRepository = livroRepository;
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

        [HttpGet]
        public IActionResult Registrar()
        {            
            ViewBag.ListaClientes_EmEmprestimo = _clienteRepository.BuscarTodosClientesAtivos(); // View Bag será apresentado em Emprestimo.Registrar.cshtml
            ViewBag.ListaBibliotecarios_EmEmprestimo = _bibliotecarioRepository.BuscarBibliotecarioAtivos(); // View Bag será apresentado em Emprestimo.Registrar.cshtml
            ViewBag.ListaLivros_EmEmprestimo = _livroRepository.BuscarTodosLivrosAtivos(); // View Bag será apresentado em Emprestimo.Registrar.cshtml

            return View();
        }

        [HttpGet]
        public JsonResult LocalizarPrecoUnitario(int id)
        {
            var livro = _livroRepository.LivroPorIdUnico(id);

            return Json(livro.PrecoUnitario);
        }

        [HttpPost]
        public IActionResult Registrar(EmprestimoModel emprestimoModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // ADICIONAR EMPRÉSTIMO PRIMEIRO
                    EmprestimoModel emprestimoCadastrado = _emprestimoRepository.AdicionarEmprestimo(emprestimoModel);

                   if (emprestimoCadastrado != null)
                    {
                        // Itens do Empréstimo
                        List<EmprestimoLivroModel> listaEmprestimoLivroModel = new List<EmprestimoLivroModel>();

                        // Desserializar o JSON
                        List<ItemEmprestimoLivroData> emprestimoLivroModels = 
                            JsonConvert.DeserializeObject<
                                List<ItemEmprestimoLivroData>>(emprestimoModel.LivrosEmprestadosModel_View);

                        try
                        {
                            foreach (var emprestimo in emprestimoLivroModels)
                            {
                                EmprestimoLivroModel emprestimoLivroModel = new EmprestimoLivroModel();
                                emprestimoLivroModel.IdEmprestimoCH = emprestimoCadastrado.Id;
                                emprestimoLivroModel.IdLivroCH = int.Parse(emprestimo.CodigoLivro);
                                emprestimoLivroModel.PrecoUnitarioAlugado = Convert.ToSingle(decimal.Parse(emprestimo.PrecoUnitario, CultureInfo.InvariantCulture));
                                emprestimoLivroModel.QuantidadeAlugadaPorLivro = int.Parse(emprestimo.QtDeProduto);
                                emprestimoLivroModel.DataDevolucao = emprestimoCadastrado.DataDevolucao;
                                emprestimoLivroModel.DataHoraEmprestimo = DateTime.Now;
                                emprestimoLivroModel.Ativo = true;
                                emprestimoLivroModel.SituacaoAtual = 1;

                                listaEmprestimoLivroModel.Add(emprestimoLivroModel);
                            }

                            var registrado = _emprestimoLivroRepository.AdicionarListaEmprestimoLivro(listaEmprestimoLivroModel);

                            if (!registrado)
                            {
                                TempData["MensagemErro"] = $"O Empréstmo dos Livros não foram cadastrados com sucesso, tente novamente. Detalhe do erro";
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new System.Exception("Houve um erro ao adicionar os dados de Empréstimo de Livros! Message: " + ex.Message);
                        }
                    }

                    TempData["MensagemSucesso"] = "Empréstmo de Livro cadastrado com sucesso";
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

        public IActionResult VisualizarItensEmprestimo(int idEmprestimoLivro)
        {
            try
            {
                if (idEmprestimoLivro > 0)
                {
                    var emprestimo = _emprestimoRepository.ListaPorIdEmprestimo(idEmprestimoLivro);

                    if (emprestimo != null)
                    {
                        return View();
                    }

                    return View();
                }
                else
                {
                    TempData["MensagemSucesso"] = "Empréstmo de Livro cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! Erro ao consultar itens de Empréstimo. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }

    // Classe temporária para Deserialisar um objeto json
    public class ItemEmprestimoLivroData
    {
        public string CodigoLivro { get; set; }
        public string DescricaoLivro { get; set; }
        public string QtDeProduto { get; set; }
        public string PrecoUnitario { get; set; }
        public string Total { get; set; }
    }
}
