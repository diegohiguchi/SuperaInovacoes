using SuperaInovacoes.Application.Produtos.Interfaces;
using SuperaInovacoes.Domain.Entities;
using SuperaInovacoes.Domain.Interfaces;
using SuperaInovacoes.Domain.Interfaces.Services;
using SuperaInovacoes.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperaInovacoes.Application.Produtos
{
    public class ProdutoApplication : BaseService, IProdutoApplication
    {
        private readonly IProdutoService _produtoService;
        public ProdutoApplication(
            IProdutoService produtoService,
            INotificador notificador) : base(notificador)
        {
            _produtoService = produtoService;
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _produtoService.ObterTodos();
        }

        public async Task<Produto> ObterProdutoPorId(Guid id)
        {
            return await _produtoService.ObterPorId(id);
        }

        public async Task Adicionar(Produto produto)
        {
            if (_produtoService.ObterPorId(produto.Id).Result != null)
            {
                Notificar("Já existe produto com esse id.");
                return;
            }

            var novoProduto = new Produto(
                produto.Nome,
                produto.Valor,
                produto.Imagem
            );

            await _produtoService.Adicionar(novoProduto);
        }

        public async Task Atualizar(Guid id, Produto produto)
        {
            var novoProduto = _produtoService.ObterPorId(id).Result;

            if (novoProduto == null)
            {
                Notificar("Produto não encontrado.");
                return;
            }

            novoProduto.AlterarNome(produto.Nome);
            novoProduto.AlterarValor(produto.Valor);
            novoProduto.AlterarImagem(produto.Imagem);

            await _produtoService.Atualizar(novoProduto);
        }

        public async Task Remover(Guid id)
        {
            var novoProduto = _produtoService.ObterPorId(id).Result;

            if (novoProduto == null)
            {
                Notificar("Produto não encontrado.");
                return;
            }

            await _produtoService.Remover(id);
        }
    }
}
