using UnitOfWork_Exemple.Entidades;

namespace UnitOfWork_Exemple.Repositorys.Interfaces
{
    public interface IPessoaRepository:IUnitOfWork
    {
        Task AdicionarPessoa(Pessoa pessoa);
    }
}
