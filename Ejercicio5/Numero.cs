using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ejercicio5
{
    public class Numero : Comparable 
    {
        private int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int GetValor()
        {
            return valor;   
        }

        public bool SosIgual(Comparable comparable)
        {
            return this.valor == ((Numero)comparable).valor;
        }

         public bool SosMenor(Comparable comparable)
        {
            return this.valor < ((Numero)comparable).valor;
        }

         public bool SosMayor(Comparable comparable)
        {
            return this.valor > ((Numero)comparable).valor;
        }

    }
}