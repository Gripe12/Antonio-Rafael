using System;

namespace FirstExerciseB
{
    public static class OneB
    {
        //recebe uma string e imprime so metade da string
        public static void HalfString(string half)
        {
            Console.WriteLine(half.Substring(half.Length / 2, half.Length));
            
        }
        // recebe uma string e confirma se começa com a e acaba com z
        public static void Startsw(string startw)
        {
            Console.WriteLine(startw.StartsWith("a"));
            Console.WriteLine(startw.EndsWith("z"));
        }

        //recebe uma string e retira os espaços no início e final da string
        public static void Clean(string perf)
        {
            Console.WriteLine(perf.Trim());
        }


    }

}
