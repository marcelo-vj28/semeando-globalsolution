using Semeando.Application.Dtos;
using Semeando.Application.Interfaces;
using Semeando.Domain.Interfaces;
using System.Collections.Generic;

namespace Semeando.Application.Services
{
    public class OpcaoApplicationService : IOpcaoApplicationService
    {
        private readonly IOpcaoRepository _opcaoRepository;

        public OpcaoApplicationService(IOpcaoRepository opcaoRepository)
        {
            _opcaoRepository = opcaoRepository;
        }

        public void CreateOpcao(OpcaoDto opcaoDto)
        {
            _opcaoRepository.Create(opcaoDto);
        }

        public void DeleteOpcao(int idPergunta, int idOpcao)
        {
            _opcaoRepository.Delete(idPergunta, idOpcao);
        }

        public IEnumerable<OpcaoDto> GetAllOpcoesByPerguntaId(int idPergunta)
        {
            return (IEnumerable<OpcaoDto>)_opcaoRepository.GetAllByPerguntaId(idPergunta);
        }

        public OpcaoDto GetOpcaoById(int idPergunta, int idOpcao)
        {
            return _opcaoRepository.GetById(idPergunta, idOpcao);
        }

        public void UpdateOpcao(OpcaoDto opcaoDto)
        {
            _opcaoRepository.Update(opcaoDto);
        }
    }
}
