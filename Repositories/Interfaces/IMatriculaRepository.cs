using Models.Entities;

namespace Repositories.Interfaces
{
    public interface IMatriculaRepository
    {
        Matricula ObterPorId(Guid id);
        void Adicionar(Matricula matricula);
        void Atualizar(Matricula matricula);
        void Remover(Guid id);
    }
}
