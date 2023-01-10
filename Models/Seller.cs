using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Nome")]
        [Required(ErrorMessage = "o campo {0} deve ser preenchido")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "o campo {0} deve ser preenchido")]
        [EmailAddress(ErrorMessage = "entre com um {0} válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "o campo {0} deve ser preenchido")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "o campo {0} deve ser preenchido")]
        [DisplayName("Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        [DisplayName("Departamento")]
        public Department Department { get; set; }
        //implementando a associação de 1 para muitos
        [DisplayName("Departamento")]
        public int DepartmentId { get; set; }
        [DisplayName("Atividade")]
        [DefaultValue(true)]
        public bool Active { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department, bool active)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
            Active = active;
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
