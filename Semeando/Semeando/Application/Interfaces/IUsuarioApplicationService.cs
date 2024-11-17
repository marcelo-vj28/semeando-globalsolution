using Semeando.Application.Dtos;
using System.Collections.Generic;

namespace Semeando.Application.Interfaces
{
    public interface IUsuarioApplicationService
    {
        UsuarioDto GetUsuarioById(int id);
        IEnumerable<UsuarioDto> GetAllUsuarios();
        void CreateUsuario(UsuarioDto usuarioDto);
        void UpdateUsuario(UsuarioDto usuarioDto);
        void DeleteUsuario(int id);
    }
}
