using GestaoDocumentos.Models;
using System.Collections.Generic;

namespace GestaoDocumentos.Repository.Interfaces
{
    public interface IClienteRepository
    {
        List<ClienteModel> BuscarTodosClientes();
        List<ClienteModel> BuscarTodosClientesAtivos();
        ClienteModel ListarPorIdCliente(int idCliente);
        ClienteModel AdicionarCliente(ClienteModel cliente);
        ClienteModel EditarCliente(ClienteModel cliente);
        bool RemoverCliente(int idcliente);
        bool AtivarCliente(int idcliente);
    }
}
