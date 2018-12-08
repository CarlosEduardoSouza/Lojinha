using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lojinha.Core.ViewModels;
using Lojinha.Core.Models;

namespace Lojinha.Infrastructure.Mappings
{
    public class ProdutoProfile : Profile
    {

        public ProdutoProfile()
        {
            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(p => p.Id, vm => vm.MapFrom(x => x.Id))
                .ForMember(p => p.Nome, vm => vm.MapFrom(x => x.Nome))
                .ForMember(p => p.Preco, vm => vm.MapFrom(x => x.Preco))
                .ForMember(p => p.ImagemUrl, vm => vm.MapFrom(x => x.ImagemPrincipalUrl));
        }


    }
}
