using Mediator.FactoryStages.Interface;

namespace Mediator.FactoryStages
{
    public class MakingYoghurt : IColleague
    {
        protected IMediator _mediator;

        public MakingYoghurt(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void Notify(string msg)
    {
            _mediator.Notify(Stages.Package, msg);
        }
}
}
