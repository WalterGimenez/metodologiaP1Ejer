using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ejercicio5
{
    public interface Comparable
    {
        bool SosIgual(Comparable comparable);
        bool SosMenor(Comparable comparable);
        bool SosMayor(Comparable comparable);
    }
}