namespace TrabalhoSD.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
