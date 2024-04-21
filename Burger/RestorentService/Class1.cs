using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Burger;

namespace RestorentService
{
    [ServiceContract]
    interface IRestaurantService
    {
        [OperationContract]
        int eat();
    }

   // [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class Customer1 : IRestaurantService
    {
        Burger.Burger b = new Burger.Burger();
        public int eat()
        {
            return b.eat();
        }
    }

    public class Customer2 : IRestaurantService
    {
        Burger.Burger b = new Burger.Burger();
        public int eat()
        {
            return b.eat() * 2;
        }
    }
}
