using System;
using System.Collections.Generic;
using System.Linq;
namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

      
        public Vendedor()
        {

        }

        public Vendedor( string nome, string email, DateTime dataNascimento, double baseSalario, Departamento departamento)
        {
            //Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AddVendas(RegistroVendas registroVendas)
        {
            Vendas.Add(registroVendas);
        }
        public void RemoveVendas(RegistroVendas registroVendas)
        {
            Vendas.Remove(registroVendas);
        }
        public double TotalVendas(DateTime dataInicial, DateTime dataFinal)
        {
            return Vendas.Where(registroVendas => registroVendas.Data >= dataInicial && registroVendas.Data <= dataFinal)
                .Sum(RegistroVendas => RegistroVendas.Quantidade);
        }

    }
}
