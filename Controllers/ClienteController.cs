using System.Collections.Generic;
using System.Linq;
using Desafio.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
            public List<Cliente> Clientes = new List<Cliente>(){
            new Cliente(){
                Id = 1,
                Nome = "Franciele",
                Email = "124578955",
                Senha = "12345",
                Documento = "1254548787",


            },
                new Cliente(){
                Id = 2,
                Nome = "Polly",
                Email = "124578955",
                Senha = "12345",
                Documento = "1254548787",
            }
        };

        public ClienteController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Clientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cliente = Clientes.FirstOrDefault(f => f.Id == id);
            if(cliente == null) return BadRequest("Cliente não encontrado");
            return Ok(cliente);
        }
    }
}