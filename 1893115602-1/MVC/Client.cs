using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.MVC
{
    public class Client
    {
        static void Main(string[] args)
        {
          AmericanController viewUS = new AmericanController();
          viewUS.DisplayPrice();
          NorwegianController viewNorway = new NorwegianController();
          viewNorway.DisplayPrice();
        }
    }
}
