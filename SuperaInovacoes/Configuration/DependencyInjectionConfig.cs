using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SuperaInovacoes.Application.Produtos;
using SuperaInovacoes.Application.Produtos.Interfaces;
using SuperaInovacoes.Domain.Interfaces;
using SuperaInovacoes.Domain.Interfaces.Repositories;
using SuperaInovacoes.Domain.Interfaces.Services;
using SuperaInovacoes.Domain.Notificacoes;
using SuperaInovacoes.Domain.Services;
using SuperaInovacoes.Infra.Context;
using SuperaInovacoes.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperaInovacoes.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddScoped<IProdutoApplication, ProdutoApplication>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}
