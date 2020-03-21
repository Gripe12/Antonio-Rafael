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
           
                
        }
        

        #endregion
    }
}
