using GestaoDocumentos.Data;
using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BancoContext _bancoContext;
        public LivroRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public LivroModel AdicionarLivro(LivroModel livro)
        {
            try
            {
                if (livro != null)
                {
                    livro.Ativo = true;
                    livro.StatusLivro = 1;
                    livro.TipoLivro = 1;

                    _bancoContext.Livros.Add(livro);
                    _bancoContext.SaveChanges();

                    return livro;
                }
                else
                {
                    throw new System.Exception("Operação de adição com falha! Entidade Livro veio vazio!");
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception("Ocorreu uma falha ao adicionar o Livro no banco de dados! Mensagem: {" + ex.Message + "}");
            }
        }

        public bool AtualizarStatusLivro(LivroModel livro, int? opcao)
        {
            if (livro != null && opcao != null)
            {
                if (opcao == 1) // Ativar                
                    livro.Ativo = true;
                else if (opcao == 2) // Desativar
                    livro.Ativo = false;

                _bancoContext.Livros.Update(livro);
                _bancoContext.SaveChanges();

                return true;                
            }
            else
            {
                throw new System.Exception("Houve um erro na edição de status do Livro! A Entidade Livro ou Opção estão nulas!");
            }
        }

        public List<LivroModel> BuscarTodosLivros()
        {
            return _bancoContext.Livros.ToList();
        }

        public List<LivroModel> BuscarTodosLivrosAtivos()
        {
            return _bancoContext.Livros.Where(l => l.Ativo == true).ToList();
        }

        public LivroModel EditarLivro(LivroModel livro)
        {
            if (livro != null)
            {
                try
                {
                    _bancoContext.Livros.Update(livro);
                    _bancoContext.SaveChanges();

                    return livro;
                }
                catch (Exception error)
                {
                    throw new System.Exception("Houve um erro na edição do livro. Erro: {0}!", error);
                }
            }
            else
            {
                throw new System.Exception("Operação de atualização com falha! Livro está vazio!");
            }
        }

        public LivroModel LivroPorIdUnico(int idLivro)
        {
            if (idLivro > 0)
            {
                LivroModel livro = _bancoContext.Livros.FirstOrDefault(l => l.Id == idLivro);
                if (livro != null)
                {
                    return livro;
                }

                return null;
            }
            else
            {
                throw new System.Exception("Operação de busca com falha! A identificação deve ser maior que zero!");
            }
        }
    }
}
