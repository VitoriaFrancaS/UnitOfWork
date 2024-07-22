using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitOfWork_Exemple.Entidades
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdMax { get; set; }
        public int QtdAtual { get; set; }

        //Foregn key
        public IEnumerable<Pessoa> Pessoa { get; set; }


    }
}
