namespace Mediator
{
    public interface IMediator
    {
        void Notify(Stages stages, string msg);
    }
}
