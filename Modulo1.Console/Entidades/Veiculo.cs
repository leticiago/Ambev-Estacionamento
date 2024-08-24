namespace Modulo1.Console.Entidades
{
    internal class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        public string? Cor { get; set; }
    }
}
