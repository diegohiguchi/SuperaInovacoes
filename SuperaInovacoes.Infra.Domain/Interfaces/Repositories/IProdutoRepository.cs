using SuperaInovacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperaInovacoes.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ListarTodos();
        Task<Produto> ObterProdutoPorId(Guid id);
    }
}
