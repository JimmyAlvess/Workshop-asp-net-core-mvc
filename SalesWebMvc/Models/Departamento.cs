using System.Collections.Generic;
using System;
using System.Linq;
namespace SalesWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }

        public Departamento( string nome)
        {
            //Id = id;
            Nome = nome;
        }
        public void AddVendedor(Vendedor vendedor)
        {
            vendedores.Add(vendedor);
           
        }
        public double TotalVendas(DateTime datainicial, DateTime datafinal)
        {
            return vendedores.Sum(vendedor => vendedor.TotalVendas(datainicial, datafinal));
        }
        

    }
}
