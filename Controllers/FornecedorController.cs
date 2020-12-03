using System.Collections.Generic;
using System.Linq;
using Desafio.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FornecedorController : ControllerBase
    {
            public List<Fornecedor> Fornecedores = new List<Fornecedor>(){
            new Fornecedor(){
                Id = 1,
                Nome = "Adria",
                Cnpj = "124578955",


            },
                new Fornecedor(){
                Id = 2,
                Nome = "Sadia",
                Cnpj = "121245787",
            }
        };

        public FornecedorController()
        {
            
        }

        public IActionResult Get(){
            return Ok(Fornecedores);
        }


        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var fornecedor = Fornecedores.FirstOrDefault(f => f.Id == id);
            if(fornecedor == null) return BadRequest("Fornecedor não encontrado");
            return Ok(fornecedor);
        }

        [HttpGet("{nome}")]
        public IActionResult GetByName(string nome)
        {
            var fornecedor = Fornecedores.FirstOrDefault(f => f.Nome.Contains(nome));
            if(fornecedor == null) return BadRequest("Fornecedor não encontrado");
            return Ok(fornecedor);
        }

        [HttpPost]
        public IActionResult Post(Fornecedor fornecedor )
        {
            return Ok(fornecedor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Fornecedor fornecedor )
        {
            return Ok(fornecedor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Fornecedor fornecedor )
        {
            return Ok(fornecedor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id )
        {
            return Ok();
        }
    }
}
