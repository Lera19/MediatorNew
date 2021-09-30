using Mediator;
using Mediator.FactoryStages;
using Mediator.FactoryStages.Interface;
using System;

namespace MediatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();

            IColleague order = new ClientOrder(mediator);
            IColleague tt = new CreatingTT(mediator);
            IColleague manufacturing = new Manufacturing(mediator);
            IColleague makingYoghurt = new MakingYoghurt(mediator);
            IColleague package = new Package(mediator);
            IColleague transfer = new TransferToWarehouse(mediator);


            mediator._order = order;
            mediator._creatingTT = tt;
            mediator._manufacturing = manufacturing;
            mediator._makingYoghurt = makingYoghurt;
            mediator._package = package;
            mediator._transferToWarehouse = transfer;

            mediator.Notify(Stages.Order, "100");

            Console.ReadKey();
        }
    }
}