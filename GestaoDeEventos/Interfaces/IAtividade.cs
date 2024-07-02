using GestaoDeEventos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Interfaces
{
    public interface IAtividade
    {
        void AdicionarParticipante(Participante participante);
        void RemoverParticipante(Participante participante);
        void AvaliarAtividade(Participante participante, int avaliacao);
        void ListarParticipantes();
        double ObterMediaAvaliacoes();

    }
}
