using Mediator.FactoryStages.Interface; 

namespace Mediator.FactoryStages
{
    public class Package : IColleague
    {
        protected IMediator _mediator;

        public Package(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Notify(string msg)
        {
            _mediator.Notify(Stages.TransferToWarehouse, msg);
        }
    }
}
