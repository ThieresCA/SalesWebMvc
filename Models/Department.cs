using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {

        [Key]
        //inserido para que o Identity seja criado automaticamente, permitindo que o construtor não precise do parametro Id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        //instanciando uma propriadade de Icollection, uma coleção de dados genérica, seja um list outro tipo
        //instanciando uma lista de vendedores
        //associação de 1 para muitos
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        //criando um método que some todas as vendas do departamento dentro do range de data
        public double TotalSales(DateTime initial, DateTime final )
        {
            //usando o método TotalSales da classe Seller para retornar as vendas de cada vendedor dentro do range de data
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
