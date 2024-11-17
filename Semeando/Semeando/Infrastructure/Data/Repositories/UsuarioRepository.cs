using Microsoft.EntityFrameworkCore;
using Semeando.Application.Dtos;
using Semeando.Domain.Entities;
using Semeando.Domain.Interfaces;
using Semeando.Infrastructure.Data.AppData;
using System.Collections.Generic;
using System.Linq;

namespace Semeando.Infrastructure.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;

        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(UsuarioEntity usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public UsuarioEntity GetById(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public IEnumerable<UsuarioEntity> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public void Update(UsuarioEntity usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = GetById(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        public void Create(UsuarioDto usuarioDto)
        {
            throw new NotImplementedException();
        }

        public void Update(UsuarioDto usuarioDto)
        {
            throw new NotImplementedException();
        }
    }
}
