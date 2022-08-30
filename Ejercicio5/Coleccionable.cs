using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    public interface Coleccionable
    {
        int Cuantos();

        Comparable Minimo();

        Comparable Maximo();

        void Agregar(Comparable comparable);

        bool Contiene(Comparable comparable);

        void Mostrar();

        void Llenar();
    }
}