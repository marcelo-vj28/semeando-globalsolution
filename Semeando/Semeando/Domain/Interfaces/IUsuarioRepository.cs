using Semeando.Application.Dtos;
using Semeando.Domain.Entities;
using System.Collections.Generic;

namespace Semeando.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        void Create(UsuarioEntity usuario);
        UsuarioEntity GetById(int id);
        IEnumerable<UsuarioEntity> GetAll();
        void Update(UsuarioEntity usuario);
        void Delete(int id);
        void Create(UsuarioDto usuarioDto);
        void Update(UsuarioDto usuarioDto);
    }
}
