using System;

namespace Services.Interfaces
{
    public interface IMatriculaService
    {
        void MatricularAluno(int alunoId, int cursoId);
        void ConcluirMatricula(int matriculaId);
    }
}

