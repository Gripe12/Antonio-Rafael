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
            bool isPrime = false;
            int a;
            for(var i = 2; i <= num1; i++)
            {

               for(a = 2; a < i; a++)
               {

                    if (i % a == 0)
                    {
                        isPrime = true;
                        break;
                    }

               }
                if(!isPrime)
                {
                    Console.Write(i + " ");
                } 
                else
                {
                    isPrime = false;
                }

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
            int min = 1;
            int max = 100;
            bool fernandoMendes = false;




            while (!fernandoMendes)
            {
                var avc = (int)Math.Floor((double)(min + max) / 2);
                var intConf = max - min;
                var keyOK = false;
                if(intConf < 2)
                {
                    for(int i = min; i < max +1; i++)
                    {
                        Console.WriteLine($"É {i}");
                        var key = Console.ReadKey().Key;
                        if (key == ConsoleKey.Y || key == ConsoleKey.S)
                        {
                            fernandoMendes = true;
                            break;
                        }
                    }
                }

                while (!keyOK)
                {
                Console.WriteLine($"O número é inferior a {avc}?");
                
                    switch (Console.ReadKey().Key) 
                    {
                        case ConsoleKey.Y:
                        case ConsoleKey.S:
                            keyOK = true;
                            max = avc - 1;
                            break;

                        case ConsoleKey.N:
                            keyOK = true;
                            min = avc;
                            break;

                        default:
                            break;

                    }

                }
            }

        }

        #endregion

    }
}


