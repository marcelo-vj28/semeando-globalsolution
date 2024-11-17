using Semeando.Application.Dtos;
using Semeando.Application.Interfaces;
using Semeando.Domain.Interfaces;
using System.Collections.Generic;

namespace Semeando.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioApplicationService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void CreateUsuario(UsuarioDto usuarioDto)
        {
            _usuarioRepository.Create(usuarioDto);
        }

        public void DeleteUsuario(int id)
        {
            _usuarioRepository.Delete(id);
        }

        public IEnumerable<UsuarioDto> GetAllUsuarios()
        {
            return (IEnumerable<UsuarioDto>)_usuarioRepository.GetAll();
        }

        public UsuarioDto GetUsuarioById(int id)
        {
            return _usuarioRepository.GetById(id);
        }

        public void UpdateUsuario(UsuarioDto usuarioDto)
        {
            _usuarioRepository.Update(usuarioDto);
        }
    }
}
