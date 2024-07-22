using System.Threading.Tasks;
using UnitOfWork_Exemple.Entidades;

namespace UnitOfWork_Exemple.Repositorys.Interfaces
{
    public interface IEventoRepository:IUnitOfWork
    {
        Task AdicionarPessoaAoEvento(int eventoId);
    }
}
