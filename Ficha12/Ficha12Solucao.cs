using System;

namespace Ficha12
{
    public class Ficha12Solucao
    {
        static void Main(string[] args)
        {

        }

        #region Exercicio1

        public static void Exercicio1()
        {
            
            int i = 0;
            int prod =  1;
            for( i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduz um numero");
                int num1 = int.Parse(Console.ReadLine());
                prod *= num1;
            }
            Console.WriteLine(prod);
        }


        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {
            Console.WriteLine("Introduz dois números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (var i = 0; i < 5; i++)
                switch (i)
                {
                    case 0:
                        Console.WriteLine(num1 + num2);
                        break;

                    case 1:
                        Console.WriteLine(num1 - num2);
                        break;

                    case 2:
                        Console.WriteLine(num1 * num2);
                        break;

                    case 3:
                        Console.WriteLine(num1 / num2);
                        break;

                    case 4:
                        Console.WriteLine(num1 % num2);
                        break;

                }
        }

        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            int z = 5;
            int x = 5;
            int y = 5;

            Console.WriteLine("Introduz dois números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine((num1 + num2) * z);
            Console.WriteLine(x * y + y * z);
        }

        #endregion

        #region Exercicio4 [x]

        public static void Exercicio4()
        {
            Console.WriteLine("Introduz um número");
            int num1 = int.Parse(Console.ReadLine());
            //bool isParse = true;

            for(var i = 1; i <= num1; i++)
            {

               for( var a = 2; a <= num1; a++)
               {

                    if (i % a != 0)
                    {
                        //isParse = false;
                        break;
                    }

               }
               Console.WriteLine(i);
                //isParse = true;
            }

        }

        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            

            Console.WriteLine("Hello?");
            var a = Console.ReadLine();
            if (a == "Is it me you're looking for?")
            {
                Console.WriteLine("I can see it in your eyes");
            }
        }

        #endregion

        #region Exercicio6

        public static void Exercicio6()
        {
            Console.WriteLine("Pense num número de 1 a 100. É maior que 50?");
            var a = Console.ReadLine();

            if (a == "S")
            {
                Console.WriteLine("É menor que 75?");

            }
            else if (a == "N")
            {
                Console.WriteLine("É maior que 50?");
            }
        }

        #endregion
    }
}

