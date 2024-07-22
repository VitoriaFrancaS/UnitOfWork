using Microsoft.EntityFrameworkCore;
using UnitOfWork_Exemple.Entidades;

namespace UnitOfWork_Exemplo.Dto.Context
{
    public class EventoDbContext:DbContext
    {
        public EventoDbContext(DbContextOptions<EventoDbContext> options): base(options)
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
