using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        //no primeiro migration isso foi utilizado para que o Identity_Insert pudesse ser feito
        [Key]
        //inserido para que o Identity seja criado automaticamente, permitindo que o construtor não precise do parametro Id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        //implementando a associação de 1 para muitos
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }

}
