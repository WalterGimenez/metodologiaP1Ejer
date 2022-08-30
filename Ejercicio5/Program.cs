using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {

        public static void Main(string[] args)
        {
        
           Console.WriteLine("Tratando de avanzar..");

            Numero num1 = new Numero(10);
            
            Console.WriteLine(num1.GetValor());

            Numero num2 = new Numero(5);

            Console.WriteLine("El valor de num1 es {0} y el valor de num2 es {1}", num1.GetValor(), num2.GetValor());

            Console.WriteLine("El valor de {0} es igual a {1} ? {2}",num2.GetValor(), num1.GetValor(), num2.SosIgual(num1));


            Console.WriteLine("Trabajo de Pila");

            //Creo una pila con Stack y push para agregar
           
            Pila pila = new Pila();

            pila.Agregar(num1);
            pila.Agregar(num2);
          
            Console.WriteLine("Número de posiciones de la pila {0}", pila.Cuantos());
            
            pila.Mostrar();

            Console.WriteLine("LLenar 20 números en forma random");
            Pila pila2 = new Pila();
            pila2.Llenar();
            pila2.Mostrar();

            Console.WriteLine("Trabajo de Cola");

            Cola cola = new Cola();

            cola.Agregar(num1);
            cola.Agregar(num2);

            Console.WriteLine("Número de posiciones de la cola {0}", cola.Cuantos());

            cola.Mostrar();

            Console.WriteLine("LLenar 20 números en forma random");
            Cola cola2 = new Cola();
            cola2.Llenar();
            
            Console.WriteLine("Los ítems de la cola son:");
            cola2.Mostrar();

            
            
            
        }

    }
}

