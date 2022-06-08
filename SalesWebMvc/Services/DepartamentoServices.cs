using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class DepartamentoServices 
    {
        private readonly SalesWebMvcContext _context;

        public DepartamentoServices(SalesWebMvcContext context)
        {
            _context = context;
        }
        public List<Departamento> EncontrarTudo()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
