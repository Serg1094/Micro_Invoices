using Core.Interfaces.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class InvoicesRepositories : IInvoices
    {
        private readonly ApplicationDbContext _context;

        public InvoicesRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Invoice>> GetInvoicesAsync()
        {
            return await _context.Invoices.Take(1).ToListAsync();
        }
    }
}
