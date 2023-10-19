using GestaoDocumentos.Models;
using System.Collections.Generic;

namespace GestaoDocumentos.Repository.Interfaces
{
    public interface IDocumentoRepository
    {
        List<DocumentoModel> BuscarTodos();
        List<DocumentoModel> BuscarTodosDocumentosAtivos();
        DocumentoModel AdicionarDocumento(DocumentoModel documento);
        DocumentoModel EditarDocumento(DocumentoModel documento);
        DocumentoModel ListarPorIdDocumento(int idDocumento);
        bool RemoverDocumento(int idDocumento);
        bool AtivarDocumento(int idDocumento);
    }
}
