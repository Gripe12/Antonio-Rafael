using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondExercise
{
    [Stuck]
    public class Drawer
    {

        
       //contem uma lista de arrays, sendo que cada array é uma gaveta com espaço para 3 objectos
       //para que se possa inserir o objecto dentro do array
       // não confirma se o objecto é afiado
        public static void Organize(object obj)
        {
        List<object[]> org = new List<object[]>();
            object[] secondtDrawer = new object[3];
            object[] thirdDrawer = new object[3];
            object[] fourthDrawer = new object[3];
            object[] fifthDrawer = new object[3];
            object[] firstDrawer = new object[3];
            org.Add(firstDrawer);
            org.Add(secondtDrawer);
            org.Add(thirdDrawer);
            org.Add(fourthDrawer);
            org.Add(fifthDrawer);

        


        }

        //baseado num número aleatório de 1 a 3, caso o número seja 2 lança a exceção IsStuckException
        public static void IsStuck()
        {
            Random rnd = new Random();
          
            int val = rnd.Next(1, 3);

            if (val == 2)
            {
                throw new IsStuckException("Raios, a gaveta está empancada outra vez");
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class , AllowMultiple = false)]
    public class StuckAttribute : Attribute
    {

    }

    public class IsStuckException : Exception
    {
        public IsStuckException(string sent)
        {
            Console.WriteLine(sent);
        }
    }
}
