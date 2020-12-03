using System;
using System.ComponentModel.DataAnnotations;

namespace Desafio.WebAPI.Models
{
    public class Venda
    {
        public Venda()
        {
        }

        public Venda(int id, int fornecedorId, int clienteId, int produtoId, decimal totalCompra, DateTime dataCompra) 
        {
            this.Id = id;
                this.FornecedorId = fornecedorId;
                this.ClienteId = clienteId;
                this.ProdutoId = produtoId;
                this.TotalCompra = totalCompra;
                this.DataCompra = dataCompra;
        
        }
                public int Id {get; set;}

        public int FornecedorId {get; set;}
        public Fornecedor Fornecedor {get; set;}

        public int ClienteId {get; set;}
        public Cliente Cliente {get; set;}

        public int ProdutoId {get; set;}
        public Produto Produto {get; set;}
        public decimal TotalCompra {get; set;}

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime DataCompra {get; set;}
    
    }
}