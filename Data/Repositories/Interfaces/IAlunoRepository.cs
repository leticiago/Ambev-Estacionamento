using Models.Entities;

namespace Data.Repositories.Interfaces
{
    public interface IAlunoRepository
    {
        Aluno ObterPorId(Guid id);
        void Adicionar(Aluno aluno);
        void Atualizar(Aluno aluno);
        void Remover(Guid id);
    }
}
