using SalesWebMvc.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        // Any testa se existe registro na tablea
        public void Somente()
        {
            if(_context.Departamento.Any() || 
                _context.Vendedor.Any() ||
                _context.RegistroVendas.Any())
            {
                return; // DB Já foi populado
            }

            Departamento d1 = new Departamento("Computador");
            Departamento d2 = new Departamento("Iphone");
            Departamento d3 = new Departamento("ComidaPet");
            Departamento d4 = new Departamento("notbook");

            Vendedor v1 = new Vendedor("Matheus Alves", "matheus.180960@gmail.com", new DateTime(2000, 8, 09), 4500.0, d1);
            Vendedor v2 = new Vendedor("Luana jesus", "luana05@gmail.com", new DateTime(2001,5, 10),5000.0, d2);
            Vendedor v3 = new Vendedor("Jimmy", "jimmypet@amorpet.com", new DateTime(2022, 05, 24),1000.0, d3);
            Vendedor v4 = new Vendedor("lara", "lara2022@gmail.com", new DateTime(1998, 04, 05), 2000.0, d4);
            Vendedor v5 = new Vendedor("Simba", "Simbapet@amorpet.com", new DateTime(2022, 05, 05), 100.0, d3);
            Vendedor v6 = new Vendedor("Alladin", "Alladin333@hotmail.com", new DateTime(1995, 9, 23), 3500.0, d2);


            RegistroVendas rv1 = new RegistroVendas( new DateTime(2022, 01, 01), 20000.0, StatusVenda.faturado,v3);
            RegistroVendas rv2 = new RegistroVendas( new DateTime(2022, 02, 09), 11000.0, StatusVenda.faturado, v1);
            RegistroVendas rv3 = new RegistroVendas( new DateTime(2022, 03, 30), 1000.0, StatusVenda.faturado, v4);
            RegistroVendas rv4 = new RegistroVendas( new DateTime(2022, 04, 015),10000.0, StatusVenda.faturado, v3);
            RegistroVendas rv5 = new RegistroVendas( new DateTime(2022, 02, 28), 5000.0, StatusVenda.faturado, v6);
            RegistroVendas rv6 = new RegistroVendas( new DateTime(2022, 05, 25), 15000.0, StatusVenda.faturado, v2);
            RegistroVendas rv7 = new RegistroVendas( new DateTime(2022, 06, 01), 20000.0, StatusVenda.faturado, v5);
            RegistroVendas rv8 = new RegistroVendas( new DateTime(2022, 01, 22), 20000.0, StatusVenda.faturado, v3);
            RegistroVendas rv9 = new RegistroVendas( new DateTime(2022, 03, 19), 11000.0, StatusVenda.faturado, v1);
            RegistroVendas rv10 = new RegistroVendas( new DateTime(2022, 05, 23), 1000.0, StatusVenda.faturado, v4);
            RegistroVendas rv11= new RegistroVendas(new DateTime(2022, 06, 17), 10000.0, StatusVenda.faturado, v3);
            RegistroVendas rv12 = new RegistroVendas( new DateTime(2022, 01, 8), 5000.0, StatusVenda.faturado, v6);
            RegistroVendas rv13 = new RegistroVendas( new DateTime(2022, 02, 22), 15000.0, StatusVenda.faturado, v2);
            RegistroVendas rv14 = new RegistroVendas( new DateTime(2022, 03, 4), 20000.0, StatusVenda.faturado, v5);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(v1,v2, v3, v4,v5,v6);

            _context.RegistroVendas.AddRange(rv1, rv2, rv3, rv4, rv5, rv6, rv7, rv8, rv9, rv10, rv11, rv12, rv13, rv14);

            _context.SaveChanges();
        }
    }
    
}
