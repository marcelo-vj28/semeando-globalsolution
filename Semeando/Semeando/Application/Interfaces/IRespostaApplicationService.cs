using Semeando.Application.Dtos;
using System.Collections.Generic;

namespace Semeando.Application.Interfaces
{
    public interface IRespostaApplicationService
    {
        RespostaDto GetRespostaById(int id);
        IEnumerable<RespostaDto> GetAllRespostasByUsuarioId(int idUsuario);
        void CreateResposta(RespostaDto respostaDto);
        void UpdateResposta(RespostaDto respostaDto);
        void DeleteResposta(int id);
    }
}
