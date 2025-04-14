using System;

namespace Calculadora
{
  class Programa
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bienvenido a Calculadora");
      while(true)
      {
        Console.WriteLine("Selecciona una opcion");
        Console.WriteLine("1 : sumar");
        Console.WriteLine("2 : restar");
        Console.WriteLine("3 : multiplicar");
        Console.WriteLine("4 : dividir");
        Console.WriteLine("0 : cerrar la calculadora");
        int opcion = int.Parse(Console.ReadLine());
        int a, b;
        if(opcion == 0)
        {
          Console.WriteLine("Gracias por usar la calculadora!");
          break;
        }
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        switch (opcion)
        {
          case 1 : Console.WriteLine("El resultado es {0}", a+b); break;
          case 2 : Console.WriteLine("El resultado es {0}", a-b); break;
          case 3 : Console.WriteLine("El resultado es {0}", a*b); break;
          case 4 : 
          {
            if(b==0) throw new DivideByZeroException();
            Console.WriteLine("El resultado es {0}", a/b); break;
          }
          default : throw new ArgumentException("Input Incorrecta, opcion"); 
        }
      }
    }
  }
}
