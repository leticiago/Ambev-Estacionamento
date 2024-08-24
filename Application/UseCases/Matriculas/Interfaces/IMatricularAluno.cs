using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Matriculas.Interfaces
{
    public interface IMatricularAluno
    {
        void Executar(Guid alunoId, Guid cursoId);
    }
}
