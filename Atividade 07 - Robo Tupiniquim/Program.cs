namespace Atividade_07___Robo_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            char cardeais = 'N';
            string comando = "EMEMEMEMM";
            char[] orientacao = comando.ToCharArray();

            Robo1(x, y, comando, orientacao, cardeais);

            Robo2(x, y, comando, orientacao, cardeais);
        }
        static void Robo1(int x, int y, string comando, char[] orientacao, char cardeais)
        {

            for (int i = 0; i < orientacao.Length; i++)
            {
                if (orientacao[i] == 'D')
                {
                    if (cardeais == 'N')
                    {
                        cardeais = 'L';
                    }
                    else if (cardeais == 'L')
                    {
                        cardeais = 'S';
                    }
                    else if (cardeais == 'S')
                    {
                        cardeais = 'O';
                    }
                    else if (cardeais == 'O')
                    {
                        cardeais = 'N';
                    }
                }

                if (orientacao[i] == 'E')
                {
                    if (cardeais == 'N')
                    {
                        cardeais = 'O';
                    }
                    else if (cardeais == 'O')
                    {
                        cardeais = 'S';
                    }
                    else if (cardeais == 'S')
                    {
                        cardeais = 'L';
                    }
                    else if (cardeais == 'L')
                    {
                        cardeais = 'N';
                    }
                }

                else if (orientacao[i] == 'M')
                {
                    if (cardeais == 'N')
                    {
                        y += 1;
                    }
                    else if (cardeais == 'L')
                    {
                        x += 1;
                    }
                    else if (cardeais == 'S')
                    {
                        y -= 1;
                    }
                    else if (cardeais == 'O')
                    {
                        x -= 1;
                    }
                }
            }
            Console.Write("As cordenadas do robô 1 são: ");
            Console.WriteLine($"{x}, {y}, {cardeais}");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Precione enter para ver a localização do robô 2");
            Console.WriteLine("-------------------------------------------------------");
            Console.ReadLine();
            return;

        }
        static void Robo2(int x, int y, string comando, char[] orientacao, char cardeais)
        {
            x = 3; y = 3; comando = "MMDMMDMDDM"; cardeais = 'L';
            orientacao = comando.ToCharArray();

            for (int i = 0; i < orientacao.Length; i++)
            {
                if (orientacao[i] == 'D')
                {
                    if (cardeais == 'N')
                    {
                        cardeais = 'L';
                    }
                    else if (cardeais == 'L')
                    {
                        cardeais = 'S';
                    }
                    else if (cardeais == 'S')
                    {
                        cardeais = 'O';
                    }
                    else if (cardeais == 'O')
                    {
                        cardeais = 'N';
                    }
                }

                if (orientacao[i] == 'E')
                {
                    if (cardeais == 'N')
                    {
                        cardeais = 'O';
                    }
                    else if (cardeais == 'O')
                    {
                        cardeais = 'S';
                    }
                    else if (cardeais == 'S')
                    {
                        cardeais = 'L';
                    }
                    else if (cardeais == 'L')
                    {
                        cardeais = 'N';
                    }
                }

                else if (orientacao[i] == 'M')
                {
                    if (cardeais == 'N')
                    {
                        y += 1;
                    }
                    else if (cardeais == 'L')
                    {
                        x += 1;
                    }
                    else if (cardeais == 'S')
                    {
                        y -= 1;
                    }
                    else if (cardeais == 'O')
                    {
                        x -= 1;
                    }
                }
            }
            Console.Write("As cordenadas do robô 2 são: ");
            Console.WriteLine($"{x}, {y}, {cardeais}");
            Console.ReadLine();
            return;
        }
    }
}
