using System;
using System.Collections.Generic;

namespace OpenClosed_Principle
{
    public sealed class Factory
    {
        internal Production Craft(IEnumerable<Craftable> craftables)
        {
            Production production = new Production(craftables);
            return production;
        }
    }
}