using Mediator.FactoryStages.Interface;
using System;

namespace Mediator
{
    public class ManagerMediator : IMediator
    {
        public IColleague _order;
        public IColleague _creatingTT;
        public IColleague _manufacturing;
        public IColleague _makingYoghurt;
        public IColleague _package;
        public IColleague _transferToWarehouse;

        public void Notify(Stages stages, string msg)
        {
            
            switch (stages)
            { 
                case Stages.Order:
                    _order.Notify(msg);
                    break;
                case Stages.CreatingTT:
                    _creatingTT.Notify(msg);
                    break;
                case Stages.Manufacturing:
                    _manufacturing.Notify(msg);
                    break;
                case Stages.MakingYoghurt:
                    _makingYoghurt.Notify(msg);
                    break;
                case Stages.Package:
                    _package.Notify(msg);
                    break;
                case Stages.TransferToWarehouse:
                    _transferToWarehouse.Notify(msg);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(stages), stages, null);
            }
        }
    }
}