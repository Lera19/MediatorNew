using Mediator.FactoryStages.Interface;
using System;

namespace Mediator.FactoryStages
{
    public class TransferToWarehouse : IColleague
    {
        protected IMediator _mediator;

        public TransferToWarehouse(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Notify(string msg)
        {
            Console.WriteLine("Your order is ready");
        }
    }
}
