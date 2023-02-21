using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
             // paso 0: 
             int Tf, resultado;
            

             

             // paso 1 pedir valores
             Console.WriteLine("Ingrese el total facturado: ");
             Tf = int.Parse(Console.ReadLine());
             
                      
             // paso 2: realizar calculo
              resultado = (Tf 5%) + 15000;

             // paso 3: emitir resultado en pantalla
              Console.WriteLine("El sueldo total es: " + resultado);
        



        }
    }
}
