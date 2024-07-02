using GestaoDeEventos.Entities;
using GestaoDeEventos.Interfaces;

class Program
{
    static List<Evento> eventos = new List<Evento>();
    static List<Participante> participantes = new List<Participante>();

    static void Main(string[] args)
    {
        InicializarDados();
        ExibirMenu();
    }

    static void InicializarDados()
    {
        // Criar eventos
        Conferencia conferencia = new Conferencia
        {
            Nome = "Conferência de Tecnologia",
            Data = DateTime.Now,
            Local = "Centro de Convenções",
            CapacidadeMax = 200,
            Artigos = 50,
            Idioma = "Português",
            Tema = "Inovações Tecnológicas"
        };

        Workshop workshop = new Workshop
        {
            Nome = "Workshop de Desenvolvimento Web",
            Data = DateTime.Now.AddDays(1),
            Local = "Sala de Treinamento",
            CapacidadeMax = 50,
        };

        eventos.Add(conferencia);
        eventos.Add(workshop);

        // Criar atividades
        Atividade palestraAI = new Atividade
        {
            Nome = "Palestra sobre Inteligência Artificial",
            Horario = DateTime.Now.AddHours(1),
            Duracao = 2,
        };

        Atividade labWeb = new Atividade
        {
            Nome = "Laboratório de Desenvolvimento Web",
            Horario = DateTime.Now.AddDays(1).AddHours(2),
            Duracao = 3,
        };

        conferencia.AdicionarAtividade(palestraAI);
        workshop.AdicionarAtividade(labWeb);

        // Criar participantes
        Palestrante palestrante = new Palestrante
        {
            Nome = "Maria Silva",
            Email = "maria.silva@example.com",
            Profissao = "Engenheira de Software",
            Formacao = "Mestrado em Ciência da Computação",
            Sobre = "Especialista em IA",
            Tema = "Inteligência Artificial"
        };

        Espectador espectador = new Espectador
        {
            Nome = "João Santos",
            Email = "joao.santos@example.com"
        };

        participantes.Add(palestrante);
        participantes.Add(espectador);

        palestrante.AdicionarEventoNaAgenda(conferencia);
        espectador.AdicionarEventoNaAgenda(workshop);
    }

    static void ExibirMenu()
    {
        int opcao;
        do
        {
            Console.WriteLine("\nMenu de Gestão de Eventos");
            Console.WriteLine("1. Listar Eventos");
            Console.WriteLine("2. Listar Participantes");
            Console.WriteLine("3. Listar Atividades de um Evento");
            Console.WriteLine("4. Adicionar Participante a um Evento");
            Console.WriteLine("5. Participar de Atividade");
            Console.WriteLine("6. Avaliar Atividade");
            Console.WriteLine("7. Ver Média de Avaliações de uma Atividade");
            Console.WriteLine("8. Listar Participantes de um Evento");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ListarEventos();
                    break;
                case 2:
                    ListarParticipantes();
                    break;
                case 3:
                    ListarAtividadesDeEvento();
                    break;
                case 4:
                    AdicionarParticipanteAEvento();
                    break;
                case 5:
                    ParticiparDeAtividade();
                    break;
                case 6:
                    AvaliarAtividade();
                    break;
                case 7:
                    VerMediaAvaliacoes();
                    break;
                case 8:
                    ListarParticipantesDeEvento();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }

    static void ListarEventos()
    {
        Console.WriteLine("\nEventos:");
        foreach (var evento in eventos)
        {
            Console.WriteLine($"- {evento.Nome} em {evento.Data} no {evento.Local}");
        }
    }

    static void ListarParticipantes()
    {
        Console.WriteLine("\nParticipantes:");
        foreach (var participante in participantes)
        {
            Console.WriteLine($"- {participante.Nome} ({participante.Email})");
        }
    }

    static void ListarAtividadesDeEvento()
    {
        Console.Write("Digite o nome do evento: ");
        string nomeEvento = Console.ReadLine();
        var evento = eventos.Find(e => e.Nome == nomeEvento);

        if (evento != null)
        {
            evento.ListarAtividades();
        }
        else
        {
            Console.WriteLine("Evento não encontrado!");
        }
    }

    static void AdicionarParticipanteAEvento()
    {
        Console.Write("Digite o nome do participante: ");
        string nomeParticipante = Console.ReadLine();
        var participante = participantes.Find(p => p.Nome == nomeParticipante);

        if (participante != null)
        {
            Console.Write("Digite o nome do evento: ");
            string nomeEvento = Console.ReadLine();
            var evento = eventos.Find(e => e.Nome == nomeEvento);

            if (evento != null)
            {
                evento.AdicionarParticipante(participante);
            }
            else
            {
                Console.WriteLine("Evento não encontrado!");
            }
        }
        else
        {
            Console.WriteLine("Participante não encontrado!");
        }
    }

    static void ParticiparDeAtividade()
    {
        Console.Write("Digite o nome do participante: ");
        string nomeParticipante = Console.ReadLine();
        var participante = participantes.Find(p => p.Nome == nomeParticipante);

        if (participante != null)
        {
            Console.Write("Digite o nome da atividade: ");
            string nomeAtividade = Console.ReadLine();
            Atividade atividade = null;

            foreach (var evento in eventos)
            {
                atividade = evento.Atividades.Find(a => a.Nome == nomeAtividade);
                if (atividade != null)
                {
                    break;
                }
            }

            if (atividade != null)
            {
                atividade.AdicionarParticipante(participante);
            }
            else
            {
                Console.WriteLine("Atividade não encontrada!");
            }
        }
        else
        {
            Console.WriteLine("Participante não encontrado!");
        }
    }

    static void AvaliarAtividade()
    {
        Console.Write("Digite o nome do participante: ");
        string nomeParticipante = Console.ReadLine();
        var participante = participantes.Find(p => p.Nome == nomeParticipante);

        if (participante != null)
        {
            Console.Write("Digite o nome da atividade: ");
            string nomeAtividade = Console.ReadLine();
            Atividade atividade = null;

            foreach (var evento in eventos)
            {
                atividade = evento.Atividades.Find(a => a.Nome == nomeAtividade);
                if (atividade != null)
                {
                    break;
                }
            }

            if (atividade != null)
            {
                Console.Write("Digite a avaliação (0 a 5): ");
                int avaliacao = int.Parse(Console.ReadLine());
                atividade.AvaliarAtividade(participante, avaliacao);
            }
            else
            {
                Console.WriteLine("Atividade não encontrada!");
            }
        }
        else
        {
            Console.WriteLine("Participante não encontrado!");
        }
    }

    static void VerMediaAvaliacoes()
    {
        Console.Write("Digite o nome da atividade: ");
        string nomeAtividade = Console.ReadLine();
        Atividade atividade = null;

        foreach (var evento in eventos)
        {
            atividade = evento.Atividades.Find(a => a.Nome == nomeAtividade);
            if (atividade != null)
            {
                break;
            }
        }

        if (atividade != null)
        {
            double media = atividade.ObterMediaAvaliacoes();
            Console.WriteLine($"A média de avaliações da atividade {nomeAtividade} é {media:F2}");
        }
        else
        {
            Console.WriteLine("Atividade não encontrada!");
        }
    }

    static void ListarParticipantesDeEvento()
    {
        Console.Write("Digite o nome do evento: ");
        string nomeEvento = Console.ReadLine();
        var evento = eventos.Find(e => e.Nome == nomeEvento);

        if (evento != null)
        {
            evento.ListarParticipantes();
        }
        else
        {
            Console.WriteLine("Evento não encontrado!");
        }
    }
}