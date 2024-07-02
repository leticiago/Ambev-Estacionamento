using GestaoDeEventos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Interfaces
{
    public interface IParticipante
    {
        void AdicionarEventoNaAgenda(Evento evento);
        void RemoverEventoDaAgenda(Evento evento);
        void ListarAgenda();
        void ParticiparDeAtividade(Atividade atividade);
        void AvaliarAtividade(Atividade atividade, int avaliacao);
    }
}
