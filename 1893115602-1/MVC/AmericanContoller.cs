using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.MVC
{
    public class AmericanController: IController
    {
      private Model mod;
 
      public void DisplayPrice()
      {
            //get price from model and add US margin 
            double cost = mod.Price()*1.1;
            String message = "Price: USD " + cost.ToString();
            Console.WriteLine(message);
      }

      public AmericanController()
      {
        mod = new Model();
      }
    }
}
