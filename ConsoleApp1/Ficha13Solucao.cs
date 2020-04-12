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
            Desenho();
            double ans;
            Calcular(out ans);
            Console.WriteLine(ans);
        }
        
        public static double Calcular(out double nr1)
        {
            double nr2;
            string op;
            bool trigger = true;

            Console.WriteLine("Escrever um nr");
            nr1 = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Operação? +, -, *, / ou = para terminar");
                op = Console.ReadLine();

                if (op == "=")
                {
                    trigger = false;
                    break;
                }

                Console.WriteLine("Escrever um nr");
                nr2 = double.Parse(Console.ReadLine());


                if (op == "+")
                {
                    nr1 += nr2;
                }
                else if (op == "-")
                {
                    nr1 -= nr2;
                }
                else if (op == "*")
                {
                    nr1 *= nr2;
                }
                else if (op == "/")
                {
                    nr1 /= nr2;
                }              
                else
                {
                }
            } while (trigger == true);
            return nr1;

        }    

        public static void Desenho()
        {
           Console.BackgroundColor = ConsoleColor.Yellow;
           Console.WriteLine("              \n  1 2 3  + -  \n  4 5 6  * /  \n  7 8 9  = CE \n              ");
        

        }

        #endregion

        #region JogoDoGalo      

        public static void JogoDoGalo()
        {
            var esp1 = "1";
            var esp2 = "2";
            var esp3 = "3";
            var esp4 = "4";
            var esp5 = "5";
            var esp6 = "6";
            var esp7 = "7";
            var esp8 = "8";
            var esp9 = "9";
            var i = 0;
            var X = "";
            var O = "";
            bool trigger = true;
            bool check = false;

            while (trigger == true)
            {

                Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                Console.WriteLine("-----------");
                Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                Console.WriteLine("-----------");
                Console.WriteLine($" {esp7} | {esp8} | {esp9} ");

                while (check == false)
                {
                    Console.WriteLine("X escolhe um espaço");
                    X = Console.ReadLine();

                    if (X == O)
                    {
                        Console.Clear();
                        Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                        Console.WriteLine("-----------");
                        Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                        Console.WriteLine("-----------");
                        Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                        Console.WriteLine("Espaço ocupado");

                    } 
                    else
                    {

                        switch (X)
                        {
                            case ("1"):
                                esp1 = "X";
                                i++;
                                check = true;
                                break;
                            case ("2"):
                                esp2 = "X";
                                i++;
                                check = true;
                                break;
                            case ("3"):
                                esp3 = "X";
                                i++;
                                check = true;
                                break;
                            case ("4"):
                                esp4 = "X";
                                i++;
                                check = true;
                                break;
                            case ("5"):
                                esp5 = "X";
                                i++;
                                check = true;
                                break;
                            case ("6"):
                                esp6 = "X";
                                i++;
                                check = true;
                                break;
                            case ("7"):
                                esp7 = "X";
                                i++;
                                check = true;
                                break;
                            case ("8"):
                                esp8 = "X";
                                i++;
                                check = true;
                                break;
                            case ("9"):
                                esp9 = "X";
                                i++;
                                check = true;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                                Console.WriteLine("-----------");
                                Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                                Console.WriteLine("-----------");
                                Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                                Console.WriteLine("Jogada Inválida");
                                continue;
                        }
                    }                  
                }
                Console.Clear();

                if (i == 9)
                {
                    trigger = false;

                    Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                    Console.WriteLine("-----------");
                    Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                    Console.WriteLine("-----------");
                    Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                    Console.WriteLine("Empate!");
                    break;
                }
                else if 
                    (//verticais
                    esp1 == "X" && esp2 == "X" && esp3 == "X" ||
                    esp4 == "X" && esp5 == "X" && esp6 == "X" ||
                    esp7 == "X" && esp8 == "X" && esp9 == "X" ||
                    //horizontais
                    esp1 == "X" && esp4 == "X" && esp7 == "X" ||
                    esp2 == "X" && esp5 == "X" && esp8 == "X" ||
                    esp3 == "X" && esp6 == "X" && esp9 == "X" ||
                    //diagonal
                    esp1 == "X" && esp5 == "X" && esp9 == "X" ||
                    esp3 == "X" && esp5 == "X" && esp7 == "X")
                {
                    Console.WriteLine("O X é um vencedor!");
                    break;
                }

                check = false;

                Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                Console.WriteLine("-----------");
                Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                Console.WriteLine("-----------");
                Console.WriteLine($" {esp7} | {esp8} | {esp9} ");

                while (check == false)
                {
                    Console.WriteLine("O escolhe um espaço");
                    O = Console.ReadLine();

                    if (O == X || O == O)
                    {
                        Console.Clear();
                        Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                        Console.WriteLine("-----------");
                        Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                        Console.WriteLine("-----------");
                        Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                        Console.WriteLine("Espaço Ocupado");
                        
                    }
                    else
                    {
                        switch (O)
                        {
                            case ("1"):
                                esp1 = "O";
                                i++;
                                check = true;
                                break;
                            case ("2"):
                                esp2 = "O";
                                i++;
                                check = true;
                                break;
                            case ("3"):
                                esp3 = "O";
                                i++;
                                check = true;
                                break;

                            case ("4"):
                                esp4 = "O";
                                i++;
                                check = true;
                                break;
                            case ("5"):
                                esp5 = "O";
                                i++;
                                check = true;
                                break;
                            case ("6"):
                                esp6 = "O";
                                i++;
                                check = true;
                                break;
                            case ("7"):
                                esp7 = "O";
                                i++;
                                check = true;
                                break;
                            case ("8"):
                                esp8 = "O";
                                check = true;
                                i++;
                                break;
                            case ("9"):
                                esp9 = "O";
                                i++;
                                check = true;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                                Console.WriteLine("-----------");
                                Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                                Console.WriteLine("-----------");
                                Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                                Console.WriteLine("Jogada Inválida");
                                check = false;
                                continue;

                        }  
                    }                   
                }

                Console.Clear(); 
                check = false;

                if
                    (//verticais
                    esp1 == "O" && esp2 == "O" && esp3 == "O" ||
                    esp4 == "O" && esp5 == "O" && esp6 == "O" ||
                    esp7 == "O" && esp8 == "O" && esp9 == "O" ||
                    //horizontais
                    esp1 == "O" && esp4 == "O" && esp7 == "O" ||
                    esp2 == "O" && esp5 == "O" && esp8 == "O" ||
                    esp3 == "O" && esp6 == "O" && esp9 == "O" ||
                    //diagonal
                    esp1 == "O" && esp5 == "O" && esp9 == "O" ||
                    esp3 == "O" && esp5 == "O" && esp7 == "O") 
                {
                    Console.WriteLine("O O é um vencedor!");
                    break;
                }                
            }
        }

        public static void Vitoria(string esp1, string esp2, string esp3, string esp4, string esp5, string esp6, string esp7, string esp8, string esp9 )
        {
            
        }

        #endregion

        #region JogoDaForca

        public static void JogoDaForca()
        {
           
                
        }
        

        #endregion
    }
}
