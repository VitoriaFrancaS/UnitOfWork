using System.ComponentModel.DataAnnotations;

namespace UnitOfWork_Exemplo.Models
{
    public class PessoaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EventoId { get; set; }      
    }
}
