using System.Collections.Generic;
using System.Linq;
using Desafio.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController : ControllerBase
    {

        public List<Venda> Vendas = new List<Venda>(){
            new Venda(){
                Id = 1,
                FornecedorId = 1,
                ClienteId = 1,
                ProdutoId = 1,
                TotalCompra = 100,
            


            },
                new Venda(){
                Id = 2,
                FornecedorId = 2,
                ClienteId = 2,
                ProdutoId = 2,
                TotalCompra = 200,
            


            },
        };

        public VendaController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Vendas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var venda = Vendas.FirstOrDefault(f => f.Id == id);
            if(venda == null) return BadRequest("Venda não encontrada");
            return Ok(venda);
        }

        [HttpPost]
        public IActionResult Post(Venda venda )
        {
            return Ok(venda);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Venda venda )
        {
            return Ok(venda);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Venda venda )
        {
            return Ok(venda);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id )
        {
            return Ok();
        }
    }
}
    