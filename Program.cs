using System;

namespace Calculadora
{
  class Programa
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bienvenido a Calculadora");
      int opcion;
      do
      {
        decimal a, b;
        Console.WriteLine("Selecciona una opcion");
        Console.WriteLine("1 : sumar");
        Console.WriteLine("2 : restar");
        Console.WriteLine("3 : multiplicar");
        Console.WriteLine("4 : dividir");
        Console.WriteLine("0 : cerrar la calculadora");
        if(!int.TryParse(Console.ReadLine(), out opcion) || opcion<0 || 4 < opcion) 
        {
          Console.WriteLine("Input Incorrecta");
          continue;
        }
        if(opcion==0) break;
        if(!decimal.TryParse(Console.ReadLine(), out a) || !decimal.TryParse(Console.ReadLine(), out b))
        {
          Console.WriteLine("Input Incorrecta");
          continue;
        }
        if(opcion==1) Console.WriteLine("El resultado es: {0}", a+b); 
        else if(opcion==2) Console.WriteLine("El resultado es: {0}", a-b);
        else if(opcion==3) Console.WriteLine("El resultado es: {0}", a*b);
        else if(opcion==4)
        {
          if(b==0) 
          {
            Console.WriteLine("No se puede dividir por cero");
            continue;
          }
          Console.WriteLine("El resultado es: {0}", a/b);
        }
      } while(true);
      Console.WriteLine("Gracias por usar la calculadora!!!!!!");
    }
  }
}
