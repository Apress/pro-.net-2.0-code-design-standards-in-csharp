using System;
using System.Collections.Generic;
using System.Text;


namespace Patterns.MVC
{
    public class NorwegianController: IController
    {
      private Model mod;

      public void DisplayPrice()
      {
        //get price from model and add Norwegian margin 
        double cost = mod.Price() * 1.15;
        String message = "Pris: USD " + cost.ToString();
        Console.WriteLine(message);
      }

      public NorwegianController()
      {
        mod = new Model();
      }
    }
}
