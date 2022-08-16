using System;
using System.Collections.Generic;
using System.Text;

namespace IsKeywordTesting
{
    abstract class Canine : Animal
    {
        public bool BelongsToPack { get; protected set; } = false;
    }
}
