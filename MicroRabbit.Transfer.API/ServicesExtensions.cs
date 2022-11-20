using Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.EventHandlers;

namespace MicroRabbit.Transfer.API
{
    public class ServicesExtensions
    {
        public static void ConfigureEventBus(IApplicationBuilder app)
        {
            var eventBus = app.ApplicationServices.GetRequiredService<IEventBus>();
            eventBus.Subscribe<TransferCreatedEvent, TransferEventHandler>();
        }
    }
}
