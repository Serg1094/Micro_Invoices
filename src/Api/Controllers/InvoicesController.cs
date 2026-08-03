using Core.Interfaces.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoices _invoicesRepository;

        public InvoicesController(IInvoices invoicesRepository)
        {
            _invoicesRepository = invoicesRepository;
        }

        [HttpGet]
        public async Task<List<Invoice>> Get()
        {
            return await _invoicesRepository.GetInvoicesAsync();
        }
    }
}
