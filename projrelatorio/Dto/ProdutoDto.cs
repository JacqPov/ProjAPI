namespace projrelatorio.Dto
{
    public class ProdutoDto
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}