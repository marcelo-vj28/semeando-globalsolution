using Semeando.Application.Dtos;
using Semeando.Application.Interfaces;
using Semeando.Domain.Interfaces;
using System.Collections.Generic;

namespace Semeando.Application.Services
{
    public class PerguntaApplicationService : IPerguntaApplicationService
    {
        private readonly IPerguntaRepository _perguntaRepository;

        public PerguntaApplicationService(IPerguntaRepository perguntaRepository)
        {
            _perguntaRepository = perguntaRepository;
        }

        public void CreatePergunta(PerguntaDto perguntaDto)
        {
            _perguntaRepository.Create(perguntaDto);
        }

        public void DeletePergunta(int id)
        {
            _perguntaRepository.Delete(id);
        }

        public IEnumerable<PerguntaDto> GetAllPerguntas()
        {
            return (IEnumerable<PerguntaDto>)_perguntaRepository.GetAll();
        }

        public PerguntaDto GetPerguntaById(int id)
        {
            return _perguntaRepository.GetById(id);
        }

        public void UpdatePergunta(PerguntaDto perguntaDto)
        {
            _perguntaRepository.Update(perguntaDto);
        }
    }
}
