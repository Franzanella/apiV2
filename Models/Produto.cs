namespace Desafio.WebAPI.Models
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(int id, string nome, string codigoProduto, decimal valor, bool promocao, decimal valorPromo, string categoria, string imagem, int quantidade, int fornecedorId) 
        {
                this.Id = id;
                this.Nome = nome;
                this.CodigoProduto = codigoProduto;
                this.Valor = valor;
                this.Promocao = promocao;
                this.ValorPromo = valorPromo;
                this.Categoria = categoria;
                this.Imagem = imagem;
                this.Quantidade = quantidade;
                this.FornecedorId = fornecedorId;
            

        }
        public int Id {get; set;}
        public string Nome {get; set;}
        public string CodigoProduto {get; set;}
        public decimal Valor {get; set;}
        public bool Promocao{get; set;}
        public decimal ValorPromo {get; set;}
        public string Categoria {get; set;}
        public string Imagem {get; set;}
        public int Quantidade {get; set;}
        public int FornecedorId {get; set;}
        public Fornecedor Fornecedor {get; set;}
    }
}