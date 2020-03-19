using System;

namespace Ficha13
{
    public class Ficha13Solucao
    {
        static void Main(string[] args)
        {
            
        }
        #region Calculadora
        public static void Calculadora()
        {
            int num1;
            int num2;
            string operation;
            int answer;

            num1 = int.Parse(Console.ReadLine());
            operation = Console.ReadLine();
            num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case ("+") :
                    answer = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + answer);
                    break;

                case ("-") :
                    answer = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + answer);
                    break;

                case ("*") :
                    answer = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + answer);
                    break;

                case ("/") :
                    answer = num1 / num2;
                    Console.WriteLine(num1 + " / " + num2 + "= " + answer);
                    break;

                case ("%") :
                    answer = num1 % num2;
                    Console.WriteLine(num1 + " % " + num2 + "  = " + answer);
                    break;


            }
        }
        #endregion

        #region JogoDoGalo



        #endregion

        #region JogoDaForca

        public static void JogoDaForca()
        {
            string[] palavras = { "bodega", "ceu", "diarreia", "pensar", "trolitada", "bola", "ar", "bambi", "pudim", "recodme" };
            string palavra = "", letra = "";
            int erros = 0, completo = 0, posicao = 0;

            bool sair = false;
            const int LIMITE = 7;
            Random rndm = new Random();

            int escolha = rndm.Next(0, 6);
            palavra = palavras[escolha];
            string[] quebrada = new string[palavra.Length];

            while(!sair)
            {
                Console.Clear();
                Console.WriteLine("Erros: {0} de {1}", erros, LIMITE);
                for ( int i = 0; i < quebrada.Length; i++)
                {
                    if (quebrada[i] != null)
                    {
                        Console.Write(quebrada[i] + " ");
                    }else 
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine("\nEscolha a posição da letra");
                posicao = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a letra");
                letra = Console.ReadLine();

                if ( palavra.ElementAt(posicao-1) == letra.ElementAt(0) )
                {
                    quebrada[posicao - 1] = letra;
                    completo++;
                }
                else
                {
                    erros++;
                }
            }
        }
        

        #endregion
    }
}
