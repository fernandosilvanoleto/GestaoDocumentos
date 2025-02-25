using GestaoDocumentos.Data;
using GestaoDocumentos.Models;
using GestaoDocumentos.Models.ViewModels.EmprestimoLivros;
using GestaoDocumentos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Repositories
{
    public class EmprestimoLivroRepository : IEmprestimoLivroRepository
    {
        private readonly BancoContext _bancoContext;

        public EmprestimoLivroRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public EmprestimoLivroModel AdicionarEmprestimoLivro(EmprestimoLivroModel emprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarListaEmprestimoLivro(List<EmprestimoLivroModel> emprestimoLivros)
        {
            if (emprestimoLivros != null)
            {
                try
                {
                    foreach (var item in emprestimoLivros)
                    {
                        _bancoContext.EmprestimoLivros.Add(item);
                        _bancoContext.SaveChanges();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    throw new System.Exception("Operação interna com falha! Empréstimo do Livro não foi cadastrado com sucesso!", ex);
                }
            }
            else
            {
                throw new System.Exception("Operação de adição com falha! Entidade Emprestimo de Lista está vazio!");
            }
        }

        public bool AjustarStatusAtivo(int idEmprestimo, int opcaoStatus)
        {
            throw new NotImplementedException();
        }

        public bool AjustarStatusEmprestimoLivro(int idEmprestimoLivro, int opcaoStatus)
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoLivroModel> BuscarTodosEmprestimosLivro()
        {
            List<EmprestimoLivroModel> emprestimoLivroModels = null;

            try
            {
                var listaPreOficial = _bancoContext.EmprestimoLivros
                    .Include(empres => empres.Emprestimo)
                    .Include(livros => livros.Livro).ToList();

                if (listaPreOficial != null)
                {
                    var listaEmprestimoLivrosViewModel = new ListaEmprestimoLivrosViewModel();
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception("Erro ao listar Empréstimo de Livro! Mensagem: ", ex);
            }

            return emprestimoLivroModels;
        }

        public List<EmprestimoLivroModel> BuscarTodosEmprestimosLivroAtivos()
        {
            throw new NotImplementedException();
        }

        public EmprestimoLivroModel EditarEmprestimoLivro(EmprestimoLivroModel emprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoLivroModel> ListaPorIdEmprestimo(int idEmprestimo)
        {
            throw new NotImplementedException();
        }

        public EmprestimoLivroModel ListaPorIdEmprestimoLivro(EmprestimoModel emprestimo)
        {
            EmprestimoLivroModel emprestimoLivroModels = null;
            ListaEmprestimoLivrosViewModel listaEmprestimoLivrosViewModel = new ListaEmprestimoLivrosViewModel();

            try
            {
                if (emprestimo != null)
                {
                    var listaEmprestimos = _bancoContext.EmprestimoLivros
                    .Include(empLivro => empLivro.Emprestimo)
                    .Include(empLivro => empLivro.Livro)
                    .Where(empLivro => empLivro.IdEmprestimoCH == emprestimo.Id)
                    //.ToQueryString();
                    .ToList();

                    //Console.WriteLine(query); // Verifique a saída SQL no console

                    // CRIAR UMA VIEWMODEL PARA EXIBIR O EMPRESTIMO E O LIVRO CORRESPONDENTE -- DESENHAR NA MÃO
                    listaEmprestimoLivrosViewModel.IdEmprestimo = emprestimo.Id;
                    listaEmprestimoLivrosViewModel.NomeEmprestimo = emprestimo.NomePersonalizado;
                    listaEmprestimoLivrosViewModel.NomeCliente = emprestimo.Cliente.Nome;
                    listaEmprestimoLivrosViewModel.NomeBibliotecario = emprestimo.Bibliotecario.Nome;
                    listaEmprestimoLivrosViewModel.DataEvolucao = emprestimo.DataDevolucao;

                    // CRIAR TODA A ESTRUTURA AQUI E DAR PARA O CONTROLLER TUDO PRONTO PORRA
                }
                else
                {
                    throw new System.Exception("Erro interno: Objeto de Empréstimo está vazio!");
                }                
            }
            catch (Exception ex)
            {
                throw new System.Exception("Erro ao listar Empréstimo de Livro! Mensagem: ", ex);
            }

            return emprestimoLivroModels;
        }

        public List<EmprestimoLivroModel> ListaPorIdLivro(int idLivro)
        {
            throw new NotImplementedException();
        }
    }
}
