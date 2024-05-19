namespace PrototypeAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }  // O SIMBOLO '?' INDICA QUE A STRING PODE RECEBER 'NULL' COMO VALOR
        public string? Senha { get; set; } // O SIMBOLO '?' INDICA QUE A STRING PODE RECEBER 'NULL' COMO VALOR
        public int? Tipo { get; set; } // TESTANDO ALTERAÇÃO NA PÁGINA DO GITHUB PARA VERIFICAR COMO O VS DETECTA NA BRANCH LOCAL 
    }
}
