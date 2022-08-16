using System;
using System.Collections.Generic;
using System.Text;

namespace IsKeywordTesting
{
    class Wolf : Canine, IPackHunter
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }

        public override void MakeNoise()
        {
            if (BelongsToPack) Console.WriteLine("I'm in a pack.");
            Console.WriteLine("ArooO!");
        }

        public void HuntInPack()
        {
            if (BelongsToPack) Console.WriteLine("I'm going to hunt with my pack!");
            else Console.WriteLine("I'm not in a pack.");
        }
    }
}
