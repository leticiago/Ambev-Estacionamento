using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Entities
{
    public class Workshop : Evento
    {
        public string Tópico { get; set; }
        public string Instrutor { get; set; }

        //nao deixar incluir mais de uma atividade
        public override void Cancelar()
        {
            Console.WriteLine($"A conferência {Nome} será cancelada.");
        }
        public override void Concluir()
        {
            Console.WriteLine($"A conferência {Nome} será concluída.");
        }
        public override void Iniciar()
        {
            Console.WriteLine($"A conferência {Nome} será iniciada.");
        }
        public override void Pausar()
        {
            Console.WriteLine($"A conferência {Nome} será pausada.");
        }
    }
}
