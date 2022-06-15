using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartamentoServices 
    {
        private readonly SalesWebMvcContext _context;

        public DepartamentoServices(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Departamento>> EncontrarTudoAsync()
        {
            return await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
