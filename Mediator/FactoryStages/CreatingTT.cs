using Mediator.FactoryStages.Interface;
using Models;
using System;

namespace Mediator.FactoryStages
{
    public class CreatingTT : IColleague
    {
        protected IMediator _mediator;
        public Initializer initializer = new Initializer();
        public CreatingTT(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void Notify(string msg)
        {
            if (CheckingParameterYoghurt(initializer.factories.Find(c => c.Yoghurt.NameYoghurt == "KLO"), "with lactose") == false)
            {
                _mediator.Notify(Stages.Manufacturing, msg);
            }
            else
            {
                Console.WriteLine("Sorry we can't doing this order, because we have problem with production");
            }
           
        }

        public bool CheckingParameterYoghurt(Factory factory, string parameter)
        {
            var result = factory.Yoghurt.Description.Contains(parameter);
            return result;

        }
    }
}
