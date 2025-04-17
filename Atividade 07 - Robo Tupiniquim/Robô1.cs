namespace Atividade_07___Robo_Tupiniquim
{
    class Robo1
    {
        public static void Robo()
        {
            int x = 1, y = 2;
            char cardeais = 'N';
            string comando = "EMEMEMEMM";
            char[] orientacao = comando.ToCharArray();


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
            Console.WriteLine($"{x}, {y}, {cardeais}");
            Console.ReadLine();
        }

    }
    
       
}
