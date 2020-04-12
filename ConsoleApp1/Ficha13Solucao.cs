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

            double ans;
            Calcular(out ans);
            Console.Clear();
            Desenho(ans);

        }

        public static double Calcular(out double nr1)
        {
            double nr2;
            string op;
            bool trigger = true;
            Desenho(0);

            Console.WriteLine("Escrever um nr");
            nr1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Desenho(nr1);

            do
            {
                Console.WriteLine("Operação? +, -, *, / ou = para terminar");
                op = Console.ReadLine();

                if (op == "=")
                {
                    trigger = false;
                    break;
                }

                Console.Clear();
                Desenho(nr1);

                Console.WriteLine("Escrever um nr");
                nr2 = double.Parse(Console.ReadLine());


                if (op == "+")
                {
                    nr1 += nr2;
                    Console.Clear();
                    Desenho(nr1);                   
                }
                else if (op == "-")
                {
                    nr1 -= nr2;
                    Console.Clear();
                    Desenho(nr1);
                }
                else if (op == "*")
                {
                    nr1 *= nr2;
                    Console.Clear();
                    Desenho(nr1);
                }
                else if (op == "/")
                {
                    nr1 /= nr2;
                    Console.Clear();
                    Desenho(nr1);
                }
                else
                {
                }
            } while (trigger == true);
            return nr1;            
        }

        public static void Desenho(double ans)
        {

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"       {ans}");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("1");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("2");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("3");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("+");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("-");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("4");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("5");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("6");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("*");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("/");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("7");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("8");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("9");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("=");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("CE");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Black;
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
            int X = 0;
            int O = 0;
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
                    X = int.Parse(Console.ReadLine());

                    if (esp1 == "X" && X ==1 || esp1 == "O" && X ==1||
                     esp2 == "X" && X ==2 || esp2 == "O" && X ==2||
                     esp3 == "X" && X == 3 || esp3 == "O" && X == 3 ||
                     esp4 == "X" && X == 4 || esp4 == "O" && X == 4 ||
                     esp5 == "X" && X == 5 || esp5 == "O" && X == 5 ||
                     esp6 == "X" && X == 6 || esp6 == "O" && X == 6 ||
                     esp7 == "X" && X == 7 || esp7 == "O" && X == 7 ||
                   esp8 == "X" && X == 8 || esp8 == "O" && X == 8 ||
                   esp9 == "X" && X == 9 || esp9 == "O" && X ==9 )
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
                            case (1):
                                esp1 = "X";
                                i++;
                                check = true;
                                break;
                            case (2):
                                esp2 = "X";
                                i++;
                                check = true;
                                break;
                            case (3):
                                esp3 = "X";
                                i++;
                                check = true;
                                break;
                            case (4):
                                esp4 = "X";
                                i++;
                                check = true;
                                break;
                            case (5):
                                esp5 = "X";
                                i++;
                                check = true;
                                break;
                            case (6):
                                esp6 = "X";
                                i++;
                                check = true;
                                break;
                            case (7):
                                esp7 = "X";
                                i++;
                                check = true;
                                break;
                            case (8):
                                esp8 = "X";
                                i++;
                                check = true;
                                break;
                            case (9):
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
                    O = int.Parse(Console.ReadLine());

                    if (esp1 == "X" && O == 1 || esp1 == "O" && O == 1 ||
                    esp2 == "X" && O == 2 || esp2 == "O" && O == 2 ||
                    esp3 == "X" && O == 3 || esp3 == "O" && O == 3 ||
                    esp4 == "X" && O == 4 || esp4 == "O" && O == 4 ||
                    esp5 == "X" && O == 5 || esp5 == "O" && O == 5 ||
                    esp6 == "X" && O == 6 || esp6 == "O" && O == 6 ||
                    esp7 == "X" && O == 7 || esp7 == "O" && O== 7 ||
                  esp8 == "X" && O == 8 || esp8 == "O" && O == 8 ||
                  esp9 == "X" && O == 9 || esp9 == "O" && O == 9)
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
                        switch (O)
                        {
                            case (1):
                                esp1 = "O";
                                i++;
                                check = true;
                                break;
                            case (2):
                                esp2 = "O";
                                i++;
                                check = true;
                                break;
                            case (3):
                                esp3 = "O";
                                i++;
                                check = true;
                                break;
                            case (4):
                                esp4 = "O";
                                i++;
                                check = true;
                                break;
                            case (5):
                                esp5 = "O";
                                i++;
                                check = true;
                                break;
                            case (6):
                                esp6 = "O";
                                i++;
                                check = true;
                                break;
                            case (7):
                                esp7 = "O";
                                i++;
                                check = true;
                                break;
                            case (8):
                                esp8 = "O";
                                check = true;
                                i++;
                                break;
                            case (9):
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

        #endregion

        #region JogoDaForca
        /*
        public static void JogodaForca()
        {
            var word = getword();
            var guess = "";
            var guesses = "";
            var lenght = word.Length;
            int lives = 6;
            var end = false;

            while (lenght > 0)
            {
                guess += "_ ";
                lenght--;
            }

            while (!end)
            {
                Console.Clear();
                DrawHangedMan(lives);
                WriteWord(guess, word, lives, lenght);
                WriteGuesses(guesses);
                var letra = AskLetter(guesses);

                guesses += " " + letra.ToString();

                CheckLetter(ref lives, ref guess, word, letra);
                end = CheckGameEnd(guess, lives);

            }

            Console.Clear();
            DrawHangedMan(lives);
            WriteWord(guess, word, lives, lenght);
            WriteGuesses(guesses);
            if (lives > 0)
                Console.WriteLine("\nParabéns adivinhou a palavra!");
            else
                Console.WriteLine("\nGAME OVER");

        }

        private static string getword()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 12);

            if (num == 1)
                return "puzzle";
            else if (num == 2)
                return "sorte";
            else if (num == 3)
                return "janela";
            else if (num == 4)
                return "jesus";
            else if (num == 5)
                return "cha";
            else if (num == 6)
                return "pizza";
            else if (num == 7)
                return "inconstitucionalmente";
            else if (num == 8)
                return "comboio";
            else if (num == 9)
                return "arquiteto";
            else if (num == 10)
                return "incognito";
            else if (num == 11)
                return "jiboia";
            else
                return "cassete";

        }

        private static void WriteWord(string guess, string word, int lives, int lenght)
        {

            if (lives == 0)
            {
                guess = "";

                foreach (char wordLetter in word)
                    guess += wordLetter + " ";

            }

            Console.WriteLine(guess);

        }

        private static void WriteGuesses(string guesses)
        {
            Console.WriteLine("\nLetras Tentadas:");
            Console.WriteLine(guesses);

        }

        private static void DrawHangedMan(int lives)
        {
            if (lives == 6)
            {
                Console.WriteLine("   ______\n" +
                                  "   |   \\|\n" +
                                  "        |\n" +
                                  "        |\n" +
                                  "        |\n" +
                                  "________|\n");

            }
            else if (lives == 5)
            {
                Console.WriteLine("   ______\n" +
                                  "   |   \\|\n" +
                                  "   O    |\n" +
                                  "        |\n" +
                                  "        |\n" +
                                  "________|\n");

            }
            else if (lives == 4)
            {
                Console.WriteLine("   ______\n" +
                                  "   |   \\|\n" +
                                  "   O    |\n" +
                                  "   |    |\n" +
                                  "        |\n" +
                                  "________|\n");
            }
            else if (lives == 3)
            {
                Console.WriteLine("   ______\n" +
                                  "   |   \\|\n" +
                                  "   O    |\n" +
                                  "  /|    |\n" +
                                  "        |\n" +
                                  "________|\n");
            }
            else if (lives == 2)
            {
                Console.WriteLine("   ______\n" +
                                  "   |   \\|\n" +
                                  "   O    |\n" +
                                  "  /|\\   |\n" +
                                  "        |\n" +
                                  "________|\n");
            }
            else if (lives == 1)
            {
                Console.WriteLine("   ______\n" +
                                  "   |   \\|\n" +
                                  "   O    |\n" +
                                  "  /|\\   |\n" +
                                  "  /     |\n" +
                                  "________|\n");
            }
            else
            {
                Console.WriteLine("   ______\n" +
                                  "   |   \\|\n" +
                                  "   O    |\n" +
                                  "  /|\\   |\n" +
                                  "  / \\   |\n" +
                                  "________|\n");
            }

        }

        private static char LerLetra()
        {
            var letra = 'a';
            var test = char.TryParse(Console.ReadLine(), out letra);

            if (test)
                return letra;
            else
                return '1';

        }

        private static char AskLetter(string guesses)
        {
            var letra = '\0';
            var test = true;

            while (test)
            {
                Console.Write("\nLetra a testar: ");
                letra = Char.ToLower(LerLetra());
                if ((letra == '1') || ((int)letra < 65 || 90 < (int)letra) && (letra < 97 || (int)letra > 122))
                {
                    Console.WriteLine("Utilize uma letra de a-z");

                }
                else
                    test = false;

                var usedletters = guesses.Split(" ");
                foreach (string k in usedletters)
                    if (letra.ToString() == k)
                    {
                        Console.WriteLine("Já utilizou esta letra. Utilize uma letra nova.");
                        test = true;
                    }

            }

            return letra;

        }

        private static void CheckLetter(ref int lives, ref string guess, string word, char letra)
        {


            if (!correct)
                lives--;

        }

        private static bool CheckGameEnd(string guess, int lives)
        {
            var leftovers = 0;

            var guessletters = guess.Split(" ");
            foreach (string k in guessletters)
            {
                if (k == "_")
                    leftovers++;
            }

            if (leftovers == 0)
            {
                return true;
            }

            if (lives == 0)
                return true;

            return false;

        }

        */
        #endregion
    }
}
