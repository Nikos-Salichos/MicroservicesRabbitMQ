using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

    }
}