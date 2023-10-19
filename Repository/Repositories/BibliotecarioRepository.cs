using GestaoDocumentos.Data;
using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Repositories
{
    public class BibliotecarioRepository : IBibliotecarioRepository
    {
        private readonly BancoContext _bancoContext;
        public BibliotecarioRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public BibliotecarioModel AdicionarBibliotecario(BibliotecarioModel bibliotecario)
        {
            try
            {
                if (bibliotecario != null)
                {
                    bibliotecario.Ativo = true;

                    _bancoContext.Bilbiotecarios.Add(bibliotecario);
                    _bancoContext.SaveChanges();

                    return bibliotecario;
                }
                else
                {
                    throw new System.Exception("A Operação de adicionar bibliotecário falhou! Entidade Bibliotecário está vazio!");
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception("Operação de adição com falha! Bibliotecário não foi cadastrado com sucesso! Erro: {0}", ex);
            }
        }        

        public List<BibliotecarioModel> BuscarTodosBibliotecarioAtivos()
        {
            return _bancoContext.Bilbiotecarios.Where(b => b.Ativo == true).OrderBy(b => b.Nome).ToList();
        }

        public List<BibliotecarioModel> BuscarTodosBibliotecarios()
        {
            return _bancoContext.Bilbiotecarios.ToList();
        }

        public BibliotecarioModel EditarBibliotecario(BibliotecarioModel bibliotecario)
        {
            try
            {
                if (bibliotecario != null)
                {
                    _bancoContext.Bilbiotecarios.Update(bibliotecario);
                    _bancoContext.SaveChanges();

                    return bibliotecario;
                }
                else
                {
                    throw new System.Exception("Operação de atualização com falha! Bibliotecário está vazio e não foi encontrado!");
                }
            }
            catch (Exception error)
            {
                throw new System.Exception("Houve um erro na edição do Bibliotecário. Erro: {0}!", error);
            }
        }

        public BibliotecarioModel ListarPorIdBibliotecario(int idBibliotecario)
        {
            if (idBibliotecario > 0)
            {
                BibliotecarioModel bibliotecarioModel = _bancoContext.Bilbiotecarios.FirstOrDefault(b => b.Id == idBibliotecario);
                if (bibliotecarioModel != null)
                {
                    return bibliotecarioModel;
                }
            }

            return null;
        }

        public bool RemoverBibliotecario(int idBibliotecario)
        {
            if (idBibliotecario >= 0)
            {
                BibliotecarioModel bibliotecario = ListarPorIdBibliotecario(idBibliotecario);
                if (bibliotecario != null)
                {
                    // FLAG DE DESATIVAÇÃO
                    bibliotecario.Ativo = false;

                    _bancoContext.Bilbiotecarios.Update(bibliotecario);
                    _bancoContext.SaveChanges();

                    return true;
                }
            }

            return false;
        }

        public bool AtivarBibliotecario(int idBibliotecario)
        {
            if (idBibliotecario >= 0)
            {
                BibliotecarioModel bibliotecario = ListarPorIdBibliotecario(idBibliotecario);
                if (bibliotecario != null)
                {
                    // FLAG DE ATIVAÇÃO
                    bibliotecario.Ativo = true;

                    _bancoContext.Bilbiotecarios.Update(bibliotecario);
                    _bancoContext.SaveChanges();

                    return true;
                }
            }

            return false;
        }
    }
}
