using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //instanciando uma propriadade de Icollection, uma coleção de dados genérica, seja um list outro tipo
        //instanciando uma lista de vendedores
        //associação de 1 para muitos
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
