using System;
using System.Data;

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
        DataTable dt = new DataTable();
        Object result;

        string? calculation = Console.ReadLine();
        if(calculation.ToLower() == "close") break;
        try 
        {
          result = dt.Compute(calculation, "");
        }
        catch (Exception e) 
        {
          Console.WriteLine("Entrada Incorrecta : {0}", e.Message);
          continue;
        }
        Console.WriteLine(result);
      } while(true);
      Console.WriteLine("Gracias por usar la calculadora!!!!!!");
    }
  }
}
