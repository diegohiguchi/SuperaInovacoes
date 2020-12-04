using Microsoft.EntityFrameworkCore;
using SuperaInovacoes.Domain.Entities;
using SuperaInovacoes.Domain.Interfaces.Repositories;
using SuperaInovacoes.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperaInovacoes.Infra.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Produto> ObterProdutoPorId(Guid id)
        {
            return await Db.Produto.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Produto>> ListarTodos()
        {
            return await Db.Produto.AsNoTracking()
                .ToListAsync();
        }
    }
}
