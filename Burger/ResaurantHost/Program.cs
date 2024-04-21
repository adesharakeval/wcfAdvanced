using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using RestorentService;
namespace ResaurantHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost h = new ServiceHost(typeof(Customer1));
          
            h.Open();
           
            Console.WriteLine("i am alive");
            Console.ReadLine();
            h.Close();
          

        }
    }
}
