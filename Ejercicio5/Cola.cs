using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    public class Cola : Coleccionable
    {
        //necesito una lista de tipo comparable
       List<Comparable> items = new List<Comparable>();


       public Comparable Minimo()
       {
            Comparable? minimo = null;

            if(items.Count > 0)
            {
                minimo = items[0];
            }

            for(int i = 0; i < items.Count; i++)
            {
                if(minimo.SosMenor(items[i]))
                {
                    minimo = items[i];
                }
            }
            return minimo;

       }

       public Comparable Maximo()
       {
            Comparable? maximo = null;

            if(items.Count > 0)
            {
                maximo = items[0];
            }

            for(int i = 1; i < items.Count; i++)
            {
                if(maximo.SosMayor(items[i]))
                {
                    maximo = items[i];
                }
            }
            return maximo;

       }

        //Se agrega ese item de tipo comparable a la lista anterior
       public void Agregar(Comparable comparable)
       {
        items.Add(comparable);
       }

       //Se verifica si el comparable que se ingresa existe dentro de la lista Comparable con el método de SosIgual de Comparable
       public bool Contiene(Comparable comparable)
       {
        return comparable.SosIgual(comparable);
       }

       public int Cuantos()
       {
        return items.Count;
       }

       public void Mostrar()
       {
        items.Reverse();
        foreach(Numero num in items)
            {
                Console.WriteLine(num.GetValor());
            }
       }

       public void Llenar()
       {
        
        for (int i = 0; i < 20; i++)
        {
            items.Add(new Numero(new Random().Next()));
        }
       }
    }
}