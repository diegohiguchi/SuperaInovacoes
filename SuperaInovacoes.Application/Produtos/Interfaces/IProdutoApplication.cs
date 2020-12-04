using SuperaInovacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperaInovacoes.Application.Produtos.Interfaces
{
    public interface IProdutoApplication
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterProdutoPorId(Guid id);
        Task Adicionar(Produto produto);
        Task Atualizar(Guid id, Produto produto);
        Task Remover(Guid id);
    }
}
