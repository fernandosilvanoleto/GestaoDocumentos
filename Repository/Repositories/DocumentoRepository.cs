using GestaoDocumentos.Data;
using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoDocumentos.Repository.Repositories
{
    public class DocumentoRepository : IDocumentoRepository
    {
        private readonly BancoContext _bancoContext;
        public DocumentoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<DocumentoModel> BuscarTodos()
        {
            return _bancoContext.Documentos.ToList();
        }

        public List<DocumentoModel> BuscarTodosDocumentosAtivos()
        {
            return _bancoContext.Documentos.Where(d => d.Ativo == true).ToList();
        }

        public DocumentoModel AdicionarDocumento(DocumentoModel documento)
        {
            try
            {
                if (documento != null)
                {
                    // ativar documento
                    documento.Ativo = true;

                    _bancoContext.Documentos.Add(documento);
                    _bancoContext.SaveChanges();

                    return documento;
                }
                else
                {
                    throw new System.Exception("Entidade Documento veio vazio para o Repository!");
                }
            }
            catch (Exception)
            {
                throw new System.Exception("Houve um erro na atualização do documento! Método: AdicionarDocumento");
            }
        }

        public DocumentoModel ListarPorIdDocumento(int idDocumento)
        {
            DocumentoModel documento = null;

            if (idDocumento > 0)
            {
                documento = _bancoContext.Documentos.FirstOrDefault(d => d.Id == idDocumento);
                if (documento != null)
                {
                    return documento;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public DocumentoModel EditarDocumento(DocumentoModel documento)
        {
            if (documento != null)
            {
                DocumentoModel documentoBD = ListarPorIdDocumento(documento.Id);
                if (documentoBD != null)
                {
                    documentoBD.Nome = documento.Nome;
                    documentoBD.Descricao = documento.Descricao;
                    documentoBD.TipoDocumento = documento.TipoDocumento;

                    _bancoContext.Documentos.Update(documentoBD);
                    _bancoContext.SaveChanges();

                    return documentoBD;
                }
                else
                {
                    throw new System.Exception("Houve um erro na atualização do documento!");
                }
            }
            return null;
        }

        public bool RemoverDocumento(int idDocumento)
        {
            if (idDocumento > 0)
            {
                DocumentoModel documentoBD = ListarPorIdDocumento(idDocumento);
                if (documentoBD != null)
                {
                    // FLAG DE INATIVAÇÃO
                    documentoBD.Ativo = false;

                    _bancoContext.Documentos.Update(documentoBD);
                    _bancoContext.SaveChanges();

                    return true;
                }
                else
                {
                    throw new System.Exception("Houve um erro na exclusão do documento!");
                }
            }

            return false;
        }

        public bool AtivarDocumento(int idDocumento)
        {
            if (idDocumento > 0)
            {
                DocumentoModel documentoBD = ListarPorIdDocumento(idDocumento);
                if (documentoBD != null)
                {
                    // FLAG DE INATIVAÇÃO
                    documentoBD.Ativo = true;

                    _bancoContext.Documentos.Update(documentoBD);
                    _bancoContext.SaveChanges();

                    return true;
                }
                else
                {
                    throw new System.Exception("Houve um erro na exclusão do documento!");
                }
            }

            return false;
        }
    }
}
