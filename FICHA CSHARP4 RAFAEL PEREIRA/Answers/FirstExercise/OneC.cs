using System;
using System.Collections.Generic;

namespace FirstExerciseC
{
    public class OneC
    {
        //rebece uma lista de inteiros e imprime cada um deles elevado a 2 somado com 8*3
        public static void ListaInt(List<int> nums)
        {
            foreach (var num in nums)
            {
                Console.WriteLine(Math.Pow(num, 2) + 8 * 3);
            }
        }
        //recebe o dia atual e mostra o próximo dia útil
        public class ExtensionMethod 
        {
            public static void Data()
            {
                var data = DateTime.Now.DayOfWeek.ToString();

                if (data == "Saturday")
                {
                    data = "Monday";
                    Console.WriteLine(data);
                }
                else if (data == "Sunday")
                {
                    data = "Monday";
                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine(DateTime.Now.AddDays(1));
                }


            }

            public static void NextWorkDay(string origin)
            {
                
            }
        }

    }
}
