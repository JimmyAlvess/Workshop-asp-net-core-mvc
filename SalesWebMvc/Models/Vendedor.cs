using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name ="Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Base Salario")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
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
