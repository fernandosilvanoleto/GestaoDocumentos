using GestaoDocumentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Repository.Interfaces
{
    public interface ILivroRepository
    {
        List<LivroModel> BuscarTodosLivros();
        List<LivroModel> BuscarTodosLivrosAtivos();
        LivroModel LivroPorIdUnico(int idLivro);
        LivroModel AdicionarLivro(LivroModel livro);
        LivroModel EditarLivro(LivroModel livro);
        bool AtualizarStatusLivro(LivroModel livro, int? opcao);

    }
}
