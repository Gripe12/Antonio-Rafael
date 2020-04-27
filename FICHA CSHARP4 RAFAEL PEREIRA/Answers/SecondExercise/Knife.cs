using System;
using System.Collections.Generic;
using System.Text;

namespace Answers.SecondExercise
{
    class Knife : ISharp
    {
        string cabo { get; set; }
        public bool CanCut()
        {
            return true;
        }

        public bool IsSharp()
        {
            return true;
        }

    }
}
