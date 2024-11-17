using Semeando.Application.Dtos;
using Semeando.Application.Interfaces;
using Semeando.Domain.Interfaces;
using System.Collections.Generic;

namespace Semeando.Application.Services
{
    public class RespostaApplicationService : IRespostaApplicationService
    {
        private readonly IRespostaRepository _respostaRepository;

        public RespostaApplicationService(IRespostaRepository respostaRepository)
        {
            _respostaRepository = respostaRepository;
        }

        public void CreateResposta(RespostaDto respostaDto)
        {
            _respostaRepository.Create(respostaDto);
        }

        public void DeleteResposta(int id)
        {
            _respostaRepository.Delete(id);
        }

        public IEnumerable<RespostaDto> GetAllRespostasByUsuarioId(int idUsuario)
        {
            return (IEnumerable<RespostaDto>)_respostaRepository.GetAllByUsuarioId(idUsuario);
        }

        public RespostaDto GetRespostaById(int id)
        {
            return _respostaRepository.GetById(id);
        }

        public void UpdateResposta(RespostaDto respostaDto)
        {
            _respostaRepository.Update(respostaDto);
        }
    }
}
