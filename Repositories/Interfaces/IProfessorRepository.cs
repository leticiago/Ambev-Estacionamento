using Models.Entities;

namespace Repositories.Interfaces
{
    public interface IProfessorRepository
    {
        Professor ObterPorId(Guid id);
        void Adicionar(Professor professor);
        void Atualizar(Professor professor);
        void Remover(Guid id);
    }
}
