﻿using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        //implementando a associação de 1 para 1
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime data, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Data = data;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
