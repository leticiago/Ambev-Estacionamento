using Data;
using Models.Entities;
using Repositories.Interfaces;

namespace Infra.Repositories
{
    public class MatriculaRepository: IMatriculaRepository
    {
        private readonly ApplicationDbContext _context;

        public MatriculaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Matricula ObterPorId(Guid id)
        {
            return _context.Matriculas.FirstOrDefault(a => a.Id == id);
        }

        public void Adicionar(Matricula Matricula)
        {
            _context.Matriculas.Add(Matricula);
            _context.SaveChanges();
        }

        public void Atualizar(Matricula Matricula)
        {
            _context.Matriculas.Update(Matricula);
            _context.SaveChanges();
        }

        public void Remover(Guid id)
        {
            var Matricula = _context.Matriculas.Find(id);
            if (Matricula != null)
            {
                _context.Matriculas.Remove(Matricula);
                _context.SaveChanges();
            }
        }
    }
}
