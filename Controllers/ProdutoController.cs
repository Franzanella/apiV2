using System.Collections.Generic;
using System.Linq;
using Desafio.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {

        public List<Produto> Produtos = new List<Produto>(){
            new Produto(){
                Id = 1,
                Nome = "Doritos",
                CodigoProduto = "1245sd",
                Valor = 12,
                Promocao = true,
                ValorPromo = 10,
                Categoria = "Salgados",
                Imagem = "doritos.png",
                Quantidade = 5,
                FornecedorId = 1,
                


            },
                new Produto(){
                Id = 2,
                Nome = "Fanta uva",
                CodigoProduto = "4545asa",
                Valor = 10,
                Promocao = true,
                ValorPromo = 10,
                Categoria = "Refrigerante",
                Imagem = "fanta.png",
                Quantidade = 3,
                FornecedorId = 2
            }
        };
        public ProdutoController()
        {
            
        }

        [HttpGet]
        public IActionResult Get(){
            return Ok(Produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produto = Produtos.FirstOrDefault(f => f.Id == id);
            if(produto == null) return BadRequest("Produto não encontrado");
            return Ok(produto);
        }
    }
}