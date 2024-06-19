using Zoologico;

class Program
{
    static void Main()
    {
        var sapo = new Anfibio("Sapo", "Amarelo", 99);
        var leao = new Mamifero("Leão", "Branco", 0);
        var papagaio = new Ave("Papagaio", "Verde");
        var tilapia = new Peixe("Tilapia", "Azul", 200);
        var cobra = new Reptil("Cobra", "Coral", 50);

        papagaio.LevantarVoo();
        papagaio.Pousar();

        tilapia.Subir(10);
        tilapia.Descer(20);
    }
}