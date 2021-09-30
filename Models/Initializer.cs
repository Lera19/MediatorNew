using System;
using System.Collections.Generic;

namespace Models
{
    public class Initializer
    {
        public List<Client> client = new List<Client>()
        {
            new Client(){ Id = Guid.NewGuid().ToString(), Name="Client1",
                Order = new Order() { CountYoghurt = 100, Price = 2000 }}
        };
        public List<Factory> factories = new List<Factory>()
        {
            new Factory(){Id = Guid.NewGuid().ToString(), Name="Factory1",
                Yoghurt=new Yoghurt(){ NameYoghurt = "KLO", Price = 15, Description = "Good" }}
        };
    }
}
