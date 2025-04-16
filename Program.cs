using System;
using System.Data;

namespace Calculadora
{
  class Programa
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bienvenido a Calculadora, usa close para cerrar el programa");
      int opcion;
      do
      {
        DataTable dt = new DataTable();
        Object result;

        string? calculation = Console.ReadLine();
        if(calculation.ToLower() == "close") break;
        try { result = dt.Compute(calculation, ""); }
        catch (Exception e) 
        {
          Console.WriteLine("Entrada Incorrecta : {0}", e.Message);
          continue;
        }
        if(double.IsInfinity(double.Parse(result.ToString())))
        {
          Console.WriteLine("Entrada Incorrecta : División por cero");
          continue;
        }
        Console.WriteLine(result);
      } while(true);
      Console.WriteLine("Gracias por usar la calculadora!!!!!!");
    }
  }
}
