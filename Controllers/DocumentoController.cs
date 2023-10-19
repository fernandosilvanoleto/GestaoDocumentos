using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Controllers
{
    public class DocumentoController : Controller
    {
        private readonly IDocumentoRepository _documentoRepository;
        public DocumentoController(IDocumentoRepository documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }
        public IActionResult Index()
        {
            var documentos = _documentoRepository.BuscarTodosDocumentosAtivos();

            return View(documentos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            if (id > 0)
            {
                var documento = _documentoRepository.ListarPorIdDocumento(id);
                if (documento != null)
                {
                    return View(documento);
                }
            }

            return View("Index");
        }

        public IActionResult Remover(int id)
        {
            if (id > 0)
            {
                var documento = _documentoRepository.ListarPorIdDocumento(id);

                if (documento != null)
                {
                    return View(documento);
                }
            }

            return View("Index");
        }

        public IActionResult RemoverDocumento(int id)
        {
            try
            {
                if (id > 0)
                {
                    bool removido = _documentoRepository.RemoverDocumento(id);

                    if (removido)
                    {
                        TempData["MensagemSucesso"] = "Documento removido com sucesso";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops! Não conseguimos remover o documento. Tente novamente mais tarde!";
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! O Documento não foi removido com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult AtivarDocumento(int id)
        {
            try
            {
                if (id > 0)
                {
                    bool removido = _documentoRepository.AtivarDocumento(id);

                    if (removido)
                    {
                        TempData["MensagemSucesso"] = "Documento ativado com sucesso";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops! Não conseguimos ativar o documento. Tente novamente mais tarde!";
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! O Documento não foi ativado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(DocumentoModel documentoModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _documentoRepository.AdicionarDocumento(documentoModel);
                    TempData["MensagemSucesso"] = "Documento cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(documentoModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Documento não cadastrado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(DocumentoModel documentoModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _documentoRepository.EditarDocumento(documentoModel);
                    TempData["MensagemSucesso"] = "Documento atualizado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", documentoModel);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops! Documento não atualizado com sucesso, tente novamente. Detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
