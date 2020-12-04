using SuperaInovacoes.Domain.Entities;
using SuperaInovacoes.ViewModels;
using AutoMapper;

namespace SuperaInovacoes.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
