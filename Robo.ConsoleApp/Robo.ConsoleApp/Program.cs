using System;

namespace Robo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string area = "5 5"; 
            string posicaoInicialRobo1 = "1 2 N";       
            string comandoRobo1 = "EMEMEMEMM"; 
            string posicaoInicialRobo2 = "3 3 L"; 
            string comandoRobo2 = "MMDMMDMDDM"; 

            string[] posicoesIniciais = new string[] { posicaoInicialRobo1, posicaoInicialRobo2 };
            string[] comandosRobo = new string[] { comandoRobo1, comandoRobo2 };


            for (int i = 0; i < 2; i++)
            {
                int posicaoXRobo, posicaoYRobo;
                char direcaoRobo;

                ObterPosicaoInicialRobo(posicoesIniciais, i, out posicaoXRobo, out posicaoYRobo, out direcaoRobo);

                ExplorarArea(comandosRobo, i, ref posicaoXRobo, ref posicaoYRobo, ref direcaoRobo);

                string[] areaSeparada = area.Split(' ');
                
                bool ehRotaInvalida = Program.ehRotaInvalida(posicaoXRobo, posicaoYRobo, areaSeparada);

                if (ehRotaInvalida)
                    Console.WriteLine("Rota invalida!");
                else             
                    ApresentarPosicaoFinal(posicaoXRobo, posicaoYRobo, direcaoRobo);              

            }
        }

        private static void ApresentarPosicaoFinal(int posicaoXRobo, int posicaoYRobo, char direcaoRobo)
        {
            string resultado = $"{posicaoXRobo} {posicaoYRobo} {direcaoRobo}";

            Console.WriteLine(resultado);
        }

        private static bool ehRotaInvalida(int posicaoXRobo, int posicaoYRobo, string[] areaSeparada)
        {
            bool ehRotaInvalida = false;

            int areaX = Convert.ToInt32(areaSeparada[0]);
            int areaY = Convert.ToInt32(areaSeparada[1]);

            if (posicaoXRobo < 0 || posicaoXRobo > areaX || posicaoYRobo < 0 || posicaoYRobo > areaY)
            {
                ehRotaInvalida = true;
            }

            return ehRotaInvalida;
        }

        private static void ExplorarArea(string[] comandosRobo, int i, ref int posicaoXRobo, ref int posicaoYRobo, ref char direcaoRobo)
        {
            char[] instrucoes = comandosRobo[i].ToCharArray();

            foreach (char instrucao in instrucoes)
            {
                if (instrucao == 'M')
                    MoverRobo(ref posicaoXRobo, ref posicaoYRobo, direcaoRobo);

                else if (instrucao == 'E')
                    direcaoRobo = VirarEsquerdaRobo(direcaoRobo);

                else if (instrucao == 'D')
                    direcaoRobo = VirarDireitaRobo(direcaoRobo);

            }
        }

        private static char VirarDireitaRobo(char direcaoRobo)
        {
            if (direcaoRobo == 'N')
                direcaoRobo = 'L';

            else if (direcaoRobo == 'S')
                direcaoRobo = 'O';

            else if (direcaoRobo == 'L')
                direcaoRobo = 'S';

            else if (direcaoRobo == 'O')
                direcaoRobo = 'N';
            return direcaoRobo;
        }

        private static char VirarEsquerdaRobo(char direcaoRobo)
        {
            if (direcaoRobo == 'N')
                direcaoRobo = 'O';

            else if (direcaoRobo == 'S')
                direcaoRobo = 'L';

            else if (direcaoRobo == 'L')
                direcaoRobo = 'N';

            else if (direcaoRobo == 'O')
                direcaoRobo = 'S';
            return direcaoRobo;
        }

        private static void MoverRobo(ref int posicaoXRobo, ref int posicaoYRobo, char direcaoRobo)
        {
            if (direcaoRobo == 'N')
                posicaoYRobo++;

            else if (direcaoRobo == 'S')
                posicaoYRobo--;

            else if (direcaoRobo == 'L')
                posicaoXRobo++;

            else if (direcaoRobo == 'O')
                posicaoXRobo--;
        }

        private static void ObterPosicaoInicialRobo(string[] posicoesIniciais, int i, out int posicaoXRobo, out int posicaoYRobo, out char direcaoRobo)
        {
            string[] posicaoInicialSeparadaRobo = posicoesIniciais[i].Split(' ');


            posicaoXRobo = Convert.ToInt32(posicaoInicialSeparadaRobo[0]);
            posicaoYRobo = Convert.ToInt32(posicaoInicialSeparadaRobo[1]);
            direcaoRobo = Convert.ToChar(posicaoInicialSeparadaRobo[2]);
        }
    }
}
