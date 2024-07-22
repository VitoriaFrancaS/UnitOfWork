using UnitOfWork_Exemple.Entidades;
using UnitOfWork_Exemple.Repositorys.Interfaces;
using UnitOfWork_Exemplo.Dto.Context;

namespace UnitOfWork_Exemple.Repositorys
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly EventoDbContext _context;

        public PessoaRepository(EventoDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarPessoa(Pessoa pessoa)
        {
            await _context.Pessoas.AddAsync(pessoa);
        }

        public async Task<bool> Commit()
        {
           return await _context.SaveChangesAsync() > 0;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
