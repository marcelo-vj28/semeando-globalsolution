using Semeando.Application.Dtos;
using Semeando.Domain.Entities;
using System.Collections.Generic;

namespace Semeando.Domain.Interfaces
{
    public interface IRespostaRepository
    {
        void Create(RespostaEntity resposta);
        RespostaEntity GetById(int id);
        IEnumerable<RespostaEntity> GetAllByUsuarioId(int usuarioId);
        void Update(RespostaEntity resposta);
        void Delete(int id);
        void Create(RespostaDto respostaDto);
        void Update(RespostaDto respostaDto);
    }
}
