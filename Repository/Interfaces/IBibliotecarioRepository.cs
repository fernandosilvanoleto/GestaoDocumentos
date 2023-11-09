using GestaoDocumentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Interfaces
{
    public interface IBibliotecarioRepository
    {
        List<BibliotecarioModel> BuscarTodosBibliotecarios();
        List<BibliotecarioModel> BuscarBibliotecarioAtivos();
        BibliotecarioModel ListarPorIdBibliotecario(int idBibliotecario);
        BibliotecarioModel AdicionarBibliotecario(BibliotecarioModel bibliotecario);
        BibliotecarioModel EditarBibliotecario(BibliotecarioModel bibliotecario);
        bool RemoverBibliotecario(int idBibliotecario);
        bool AtivarBibliotecario(int idBibliotecario);
    }
}
