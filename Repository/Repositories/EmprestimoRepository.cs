using GestaoDocumentos.Data;
using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly BancoContext _bancoContext;

        public EmprestimoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public EmprestimoModel AdicionarEmprestimo(EmprestimoModel emprestimo)
        {
            if (emprestimo != null)
            {
                try
                {
                    emprestimo.Ativo = true;
                    emprestimo.DataHora = DateTime.Now;
                    emprestimo.StatusEmprestimo = "Ativo";

                    _bancoContext.Emprestimos.Add(emprestimo);
                    _bancoContext.SaveChanges();

                    return emprestimo;
                }
                catch (Exception ex)
                {
                    throw new System.Exception("Operação de adição com falha! Empréstimo não foi cadastrado com sucesso!", ex);
                }
            }
            else
            {
                throw new System.Exception("Operação de adição com falha! Entidade Emprestimo veio vazio!");
            }
        }

        public bool AjustarStatusAtivo(int idEmprestimo, int opcaoStatus)
        {
            if (idEmprestimo > 0 && opcaoStatus > 0)
            {
                EmprestimoModel emprestimo = ListaPorIdEmprestimo(idEmprestimo);
                if (emprestimo != null)
                {
                    try
                    {
                        if (opcaoStatus == 1)
                            emprestimo.Ativo = true;

                        else if (opcaoStatus == 2)
                            emprestimo.Ativo = false;

                        else
                            return false;

                        _bancoContext.Emprestimos.Update(emprestimo);
                        _bancoContext.SaveChanges();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new System.Exception("Operação de ajustes de status com falha! Empréstimo não foi alterado com sucesso!", ex);
                    }                    
                }          
            }

            return false;          
        }

        public bool AjustarStatusEmprestimo(int idEmprestimo, int opcaoStatus)
        {
            throw new NotImplementedException();
        }

        public List<EmprestimoModel> BuscarTodosEmprestimos()
        {
            return _bancoContext.Emprestimos.ToList();
        }

        public List<EmprestimoModel> BuscarTodosEmprestimosAtivos()
        {
            return _bancoContext.Emprestimos.Where(e => e.Ativo == true).ToList();
        }

        public EmprestimoModel EditarEmprestimo(EmprestimoModel emprestimo)
        {
            if (emprestimo != null && emprestimo.Id > 0)
            {
                try
                {
                    _bancoContext.Emprestimos.Update(emprestimo);
                    _bancoContext.SaveChanges();

                    return emprestimo;
                }
                catch (Exception ex)
                {
                    throw new System.Exception("Operação de atualização com falha! Cliente não encontrado!", ex);
                }                
            }
            else
            {
                throw new System.Exception("Operação de edição com falha! Entidade Empréstimo veio vazio!");
            }
        }

        public List<EmprestimoModel> ListaPorIdBibliotecarioEmprestimos(int IdBibliotecario)
        {
            if (IdBibliotecario > 0)
            {
                var emprestimos = _bancoContext.Emprestimos.Where(e => e.IdBibliotecarioCH == IdBibliotecario).ToList();
                if (emprestimos != null)
                {
                    return emprestimos;
                }
            }

            return null;
        }

        public List<EmprestimoModel> ListaPorIdClientesEmprestimos(int idCliente)
        {
            if (idCliente > 0)
            {
                var emprestimos = _bancoContext.Emprestimos.Where(e => e.IdClienteCH == idCliente).ToList();
                if (emprestimos != null)
                {
                    return emprestimos;
                }
            }

            return null;
        }

        public EmprestimoModel ListaPorIdEmprestimo(int idEmprestimo)
        {
            if (idEmprestimo > 0)
            {
                var emprestimo = _bancoContext.Emprestimos.FirstOrDefault(e => e.Id == idEmprestimo);

                // trazer os dados de clientes aqui
                if (emprestimo != null)
                {
                    return emprestimo;
                }
            }

            return null;
        }
    }
}
