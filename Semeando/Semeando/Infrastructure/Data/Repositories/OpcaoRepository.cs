using Microsoft.EntityFrameworkCore;
using Semeando.Domain.Entities;
using Semeando.Domain.Interfaces;
using Semeando.Infrastructure.Data.AppData;
using System.Collections.Generic;
using System.Linq;

namespace Semeando.Infrastructure.Data.Repositories
{
    public class OpcaoRepository : IOpcaoRepository
    {
        private readonly ApplicationContext _context;

        public OpcaoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(OpcaoEntity opcao)
        {
            _context.Opcoes.Add(opcao);
            _context.SaveChanges();
        }

        public OpcaoEntity GetById(int perguntaId, int idOpcao)
        {
            return _context.Opcoes.FirstOrDefault(o => o.PerguntaId == perguntaId && o.Id == idOpcao);
        }

        public IEnumerable<OpcaoEntity> GetAllByPerguntaId(int perguntaId)
        {
            return _context.Opcoes.Where(o => o.PerguntaId == perguntaId).ToList();
        }

        public void Update(OpcaoEntity opcao)
        {
            _context.Opcoes.Update(opcao);
            _context.SaveChanges();
        }

        public void Delete(int perguntaId, int idOpcao)
        {
            var opcao = GetById(perguntaId, idOpcao);
            if (opcao != null)
            {
                _context.Opcoes.Remove(opcao);
                _context.SaveChanges();
            }
        }
    }
}
