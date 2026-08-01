using Core.Interfaces.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class InvoicesRepositories : IInvoices
    {
        public async Task<List<Invoice>> GetInvoicesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
