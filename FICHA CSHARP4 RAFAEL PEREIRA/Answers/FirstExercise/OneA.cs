using System;

namespace FirstExerciseA
{
    public static class OneA
    {
        //recebe um array de inteiros e imprime apenas os que são maiores do que 50
        // impares e divisíveis por 9
        public static void Numbers(int[] nums)
        {

            foreach( var num in nums)
            {
                if(num > 50 && num % 2 == 1 && num % 9 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

}

   

}
