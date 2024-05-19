namespace PrototypeAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; } // O SIMBOLO '?' INDICA QUE A STRING PODE RECEBER 'NULL' COMO VALOR
        public string? Descricao { get; set; } // O SIMBOLO '?' INDICA QUE A STRING PODE RECEBER 'NULL' COMO VALOR
        public string? Preco { get; set; } // O SIMBOLO '?' INDICA QUE A STRING PODE RECEBER 'NULL' COMO VALOR
    }
}
