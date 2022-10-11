namespace Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        public void Publish<T>(T @event) where T : Event;

        public void Subscribe<T, THandler>() where T : Event
                                            where THandler : IEventHandler<T>

    }
}
