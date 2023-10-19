using GestaoDocumentos.Data;
using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GestaoDocumentos.Repository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ClienteModel AdicionarCliente(ClienteModel cliente)
        {
            try
            {
                if (cliente != null)
                {
                    cliente.Ativo = true;

                    _bancoContext.Clientes.Add(cliente);
                    _bancoContext.SaveChanges();

                    return cliente;
                }
                else
                {
                    throw new System.Exception("Operação de adição com falha! Entidade Cliente veio vazio!");
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception("Operação de adição com falha! Cliente não foi cadastrado com sucesso!");
            }
        }

        public List<ClienteModel> BuscarTodosClientes()
        {
            return _bancoContext.Clientes.ToList();
        }

        public List<ClienteModel> BuscarTodosClientesAtivos()
        {
            return _bancoContext.Clientes.Where(c => c.Ativo == true).ToList();
        }

        public ClienteModel EditarCliente(ClienteModel cliente)
        {
            try
            {
                if (cliente != null)
                {
                    _bancoContext.Clientes.Update(cliente);
                    _bancoContext.SaveChanges();

                    return cliente;
                }
                else
                {
                    throw new System.Exception("Operação de atualização com falha! Cliente não encontrado!");
                }
            }
            catch (System.Exception error)
            {
                throw new System.Exception("Houve um erro na edição do cliente. Erro: {0}!", error);
            }
        }

        public ClienteModel ListarPorIdCliente(int idCliente)
        {
            if (idCliente > 0)
            {
                var cliente = _bancoContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
                if (cliente != null)
                {
                    return cliente;
                }
            }

            return null;
        }

        public bool RemoverCliente(int idcliente)
        {
            if (idcliente > 0)
            {
                ClienteModel clienteDB = ListarPorIdCliente(idcliente);
                if (clienteDB != null)
                {
                    // FLAG DE INATIVAÇÃO DE CLIENTES;
                    clienteDB.Ativo = false;

                    _bancoContext.Clientes.Update(clienteDB);
                    _bancoContext.SaveChanges();

                    return true;
                }
                else
                {
                    throw new System.Exception("Houve um erro na exclusão do cliente!");
                }
            }

            return false;
        }

        public bool AtivarCliente(int id)
        {
            if (id > 0)
            {
                ClienteModel clienteDB = ListarPorIdCliente(id);
                if (clienteDB != null)
                {
                    // FLAG DE ATIVAÇÃO DE CLIENTES;
                    clienteDB.Ativo = true;

                    _bancoContext.Clientes.Update(clienteDB);
                    _bancoContext.SaveChanges();

                    return true;
                }
                else
                {
                    throw new System.Exception("Houve um erro na exclusão do cliente!");
                }
            }

            return false;
        }        
    }
}
