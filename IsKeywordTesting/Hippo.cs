using System;
using System.Collections.Generic;
using System.Text;

namespace IsKeywordTesting
{
    class Hippo : Animal, ISwimmer    
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Grunt.");
        }
        public void Swim()
        {
            Console.WriteLine("Splash! Imma' going'a for'a sweem.");
        }
    }
}
