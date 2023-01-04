using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        //no primeiro migration isso foi utilizado para que o Identity_Insert pudesse ser feito
        [Key]
        //inserido para que o Identity seja criado automaticamente, permitindo que o construtor não precise do parametro Id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        //implementando a associação de 1 para 1
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
