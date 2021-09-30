using Mediator.FactoryStages.Interface;
using Models;
using System;

namespace Mediator.FactoryStages
{
    public class ClientOrder : IColleague
    {
        protected IMediator _mediator;
        public Initializer initializer= new Initializer();

        public ClientOrder(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Notify(string msg)
        {
            Console.WriteLine("Email from factory: Order from "+ msg +" count yoghurt");
            if (ComparisonPriceForOrderSmaller(initializer.client.Find(c => c.Order.Price == 2000), initializer.factories.Find(c => c.Yoghurt.NameYoghurt == "KLO")) == true)
            {
                _mediator.Notify(Stages.CreatingTT, msg);
            }
            else
            {
                Console.WriteLine("Sorry we can't doing this order, because price order more than you wanted");
            }
        }

        public bool ComparisonPriceForOrderSmaller(Client client, Factory factory)
        {
            var result = factory.Yoghurt.Price * client.Order.CountYoghurt <= client.Order.Price;
            return result;

        }
    }
}
