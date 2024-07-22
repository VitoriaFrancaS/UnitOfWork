using System.ComponentModel.DataAnnotations;

namespace UnitOfWork_Exemplo.Models
{
    public class PessoaRequest
    {
        public string Nome { get; set; }
        [Range(1, int.MaxValue)]
        public int EventoId { get; set; }
    }
}
