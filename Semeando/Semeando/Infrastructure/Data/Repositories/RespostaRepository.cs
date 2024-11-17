using Microsoft.EntityFrameworkCore;
using Semeando.Domain.Entities;
using Semeando.Domain.Interfaces;
using Semeando.Infrastructure.Data.AppData;
using System.Collections.Generic;
using System.Linq;

namespace Semeando.Infrastructure.Data.Repositories
{
    public class RespostaRepository : IRespostaRepository
    {
        private readonly ApplicationContext _context;

        public RespostaRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(RespostaEntity resposta)
        {
            _context.Respostas.Add(resposta);
            _context.SaveChanges();
        }

        public RespostaEntity GetById(int id)
        {
            return _context.Respostas.Include(r => r.Usuario)
                                     .Include(r => r.Pergunta)
                                     .Include(r => r.Opcao)
                                     .FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<RespostaEntity> GetAllByUsuarioId(int usuarioId)
        {
            return _context.Respostas.Include(r => r.Pergunta)
                                     .Include(r => r.Opcao)
                                     .Where(r => r.UsuarioId == usuarioId)
                                     .ToList();
        }

        public void Update(RespostaEntity resposta)
        {
            _context.Respostas.Update(resposta);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var resposta = GetById(id);
            if (resposta != null)
            {
                _context.Respostas.Remove(resposta);
                _context.SaveChanges();
            }
        }
    }
}
