namespace Atividade07Robo.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Robo robo1 = new Robo();

        string posicaoInicial = "1 2 N";
        string comando = "EMEMEMEMM";

        string[] coordenadasIniciais = posicaoInicial.Split(' ');

        robo1.posicaoX = Convert.ToInt32(coordenadasIniciais[0]);
        robo1.posicaoY = Convert.ToInt32(coordenadasIniciais[1]);
        robo1.direcao = Convert.ToChar(coordenadasIniciais[2]);

        char[] instrucoes = comando.ToCharArray();

        robo1.Explorar(instrucoes);

        robo1.ExibirCoordenadas();

        string posicaoInicialDois = "3 3 L";
        string comandoDois = "MMDMMDMDDM";

        Robo robo2 = new Robo();

        string[] coordenadasIniciaisDois = posicaoInicialDois.Split(' ');

        robo2.posicaoX = Convert.ToInt32(coordenadasIniciaisDois[0]);
        robo2.posicaoY = Convert.ToInt32(coordenadasIniciaisDois[1]);
        robo2.direcao = Convert.ToChar(coordenadasIniciaisDois[2]);

        char[] instrucoesDois = comandoDois.ToCharArray();

        robo2.Explorar(instrucoesDois);

        robo2.ExibirCoordenadas();

        Console.ReadLine();
    }
}