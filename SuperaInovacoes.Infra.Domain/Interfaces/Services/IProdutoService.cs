using SuperaInovacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperaInovacoes.Domain.Interfaces.Services
{
    public interface IProdutoService : IDisposable
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
        Task<Produto> ObterPorId(Guid id);
    }
}
