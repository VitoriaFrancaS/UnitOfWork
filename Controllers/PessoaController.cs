using Microsoft.AspNetCore.Mvc;
using UnitOfWork_Exemple.Entidades;
using UnitOfWork_Exemple.Repositorys.Interfaces;
using UnitOfWork_Exemplo.Models;

namespace UnitOfWork_Exemplo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController:ControllerBase
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IEventoRepository eventoRepository, IPessoaRepository pessoaRepository)
        {
            _eventoRepository = eventoRepository;
            _pessoaRepository = pessoaRepository;
        }

        [HttpPost]
        public async Task<PessoaViewModel> AdiconarPessoa([FromBody] PessoaRequest pessoa)
        {
            var pessoaModel = new Pessoa
            {
                EventoId = pessoa.EventoId,
                Nome = pessoa.Nome
            };

            await _pessoaRepository.AdicionarPessoa(pessoaModel);

            await _eventoRepository.AdicionarPessoaAoEvento(pessoa.EventoId);

            await _pessoaRepository.Commit();

            return new PessoaViewModel
            {
                EventoId = pessoaModel.EventoId,
                Nome = pessoaModel.Nome,
                Id = pessoaModel.Id
            };

        }




    }
}
