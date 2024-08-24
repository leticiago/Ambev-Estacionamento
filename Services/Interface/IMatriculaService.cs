using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IMatriculaService
    {
        void MatricularAluno(Guid alunoId, Guid cursoId);
        void ConcluirMatricula(Guid matriculaId);
    }
}
