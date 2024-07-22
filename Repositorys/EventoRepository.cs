using UnitOfWork_Exemple.Repositorys.Interfaces;
using UnitOfWork_Exemplo.Dto.Context;

namespace UnitOfWork_Exemple.Repositorys
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventoDbContext _context;

        public EventoRepository(EventoDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarPessoaAoEvento(int eventoId)
        {
            var evento = await _context.Eventos.FindAsync(eventoId);

            if (evento == null)
            {
                throw new Exception("Evento não encontrado");
            }

            if(evento.QtdAtual == evento.QtdMax)
            {
                throw new Exception("Lotação máxima do evento atingida");
            }

            evento.QtdAtual += 1;

            _context.Eventos.Update(evento);
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
