using AutoMapper;
using Lojinha.Core.Models;
using Lojinha.Core.Services;
using Lojinha.Core.ViewModels;
using Lojinha.Infrastructure.Storage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {

        private readonly IProdutoServices _produtoServices;
        private readonly IMapper _mapper;
        public ProdutosController(IProdutoServices produtoservices, IMapper mapper)
        {
            _produtoServices = produtoservices;
            _mapper = mapper;
        }
        public IActionResult Create()
        {
            var produto = new Produto
            {
                Id = 330840,
                Nome = "LG G4",
                Categoria = new Categoria
                {
                    Id = 1,
                    Nome = "Celulares"
                },
                Descricao = "Lg G4 plus",
                Fabricante = new Fabricante
                {
                    Id = 1,
                    Nome = "G4 - Plus"
                },
                Preco = 1800m,
                Tags = new[] { "Lg G4", "celular", "lg" },
                ImagemPrincipalUrl = "https://icdn4.digitaltrends.com/image/lg-g4-off-1500x1000-640x640.jpg?ver=1"

            };

            //_azureStorage.AddProduto(produto);
            return Content("Ok");
        }

        public async Task<IActionResult> List()
        {
            var produtos = await _produtoServices.ObterProdutos();
            var vm = _mapper.Map<List<ProdutoViewModel>>(produtos);

            return View(vm);
        }

        public async Task<IActionResult> Details(string id)
        {
            var produto = await _produtoServices.ObterProduto(id);
            return Json(produto);
        }
    }
}
