using System;
using System.Collections.Generic;
using System.Text;

namespace Answers.SecondExercise
{
    class Dagger : ISharp
    {
        //indica que é capaz de cortar
        public bool CanCut()
        {
            return true;

        }
        //indica que está afiado
        public bool IsSharp()
        {
            return true;

        }
    }
}
