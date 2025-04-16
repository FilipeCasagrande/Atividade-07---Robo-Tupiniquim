namespace Atividade_07___Robo_Tupiniquim
{
    internal class Program
    {
        // Comando EMEMEMEMEMM
        // char [] instrucao = comando.tochararray();

        static void Main(string[] args)
        {
            int x = 1, y = 2;
            char cardeais = 'N';
            string comando = "EMEMEMEMM";
            char[] orientacao = comando.ToCharArray();


            for (int i = 0; i < orientacao.Length; i++)
            {

                if (orientacao[i] == 'E')
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

            }   
            Console.WriteLine(cardeais);
            Console.ReadLine();
        }
    }
}
