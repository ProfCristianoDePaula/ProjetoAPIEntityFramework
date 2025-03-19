namespace ProjetoAPIEntityFramework.Model
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public bool? Ativo { get; set; } = true;
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
