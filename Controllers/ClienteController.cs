using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IActionResult Index()
        {
            var clientes = _clienteRepository.BuscarTodosClientesAtivos();

            return View(clientes);
        }

        public IActionResult IndexTodosClientes()
        {
            var clientes = _clienteRepository.BuscarTodosClientes();

            return View(clientes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ClienteModel clienteModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clienteRepository.AdicionarCliente(clienteModel);
                    TempData["MensagemSucesso"] = "Documento cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(clienteModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Cliente não cadastrado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            if (id > 0)
            {
                var cliente = _clienteRepository.ListarPorIdCliente(id);
                if (cliente != null)
                {
                    return View(cliente);
                }
                else
                {
                    throw new System.Exception("Houve um erro ao buscar cliente na base de dados!");
                }
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult Editar(ClienteModel clienteModel)
        {
            try
            {
                if (ModelState.IsValid && clienteModel != null)
                {
                    _clienteRepository.EditarCliente(clienteModel);
                    TempData["MensagemSucesso"] = "Cliente atualizado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", clienteModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! Cliente não atualizado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Remover(int id)
        {
            if (id > 0)
            {
                var cliente = _clienteRepository.ListarPorIdCliente(id);

                if (cliente != null)
                {
                    return View(cliente);
                }
            }

            return View("Index");
        }

        public IActionResult RemoverCliente(int id)
        {
            try
            {
                if (id > 0)
                {
                    bool removido = _clienteRepository.RemoverCliente(id);

                    if (removido)
                    {
                        TempData["MensagemSucesso"] = "Cliente excluído com sucesso";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops! Não conseguimos excluir o cliente. Tente novamente mais tarde!";
                    }
                }

                return RedirectToAction("IndexTodosClientes");
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! O Cliente não foi excluído com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult AtivarCliente(int id)
        {
            try
            {
                if (id > 0)
                {
                    bool removido = _clienteRepository.AtivarCliente(id);

                    if (removido)
                    {
                        TempData["MensagemSucesso"] = "Cliente ativado com sucesso";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops! Não conseguimos ativar o cliente. Tente novamente mais tarde!";
                    }
                }

                return RedirectToAction("IndexTodosClientes");
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! O Cliente não foi ativado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
