using Mediator.FactoryStages.Interface;

namespace Mediator.FactoryStages
{
    public class Manufacturing : IColleague
    {
        protected IMediator _mediator;

        public Manufacturing(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Notify(string msg)
    {
            _mediator.Notify(Stages.MakingYoghurt, msg);
        }
}
}

