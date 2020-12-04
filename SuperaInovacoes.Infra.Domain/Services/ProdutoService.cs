using SuperaInovacoes.Domain.Entities;
using SuperaInovacoes.Domain.Interfaces.Repositories;
using SuperaInovacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperaInovacoes.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _produtoRepository.ListarTodos();
        }

        public async Task Adicionar(Produto produto)
        {
            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public async Task<Produto> ObterPorId(Guid id)
        {
            return _produtoRepository.ObterProdutoPorId(id).Result;
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
