using System.Threading.Tasks;

namespace UnitOfWork_Exemple.Repositorys.Interfaces
{
    public interface IUnitOfWork
    {
        //Adicionando as coisas ao banco de dados
        Task<bool> Commit();

        //Reverte as alterações que o usuario já havia feio antes de mandar p/ o banco de dados,
        //mantendo assim a integridade do banco de dados
        Task Rollback();
    }
}
