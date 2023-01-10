using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerlistViewModel
    {
        [DisplayName("Vendedores")]
        public ICollection<Seller> Sellers { get; set; }
    }
}
