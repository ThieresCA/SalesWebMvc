using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SalesRecordServices
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordServices(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            //criando um query q vai ser executada pelo DBSET no banco de dados para retornar os dados
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                //criando a restrição de data minima caso minDate tenha sido preenchido
                result = result.Where(c => c.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                //criando a restrição de data minima caso minDate tenha sido preenchido
                result = result.Where(c => c.Date <= maxDate.Value);
            }
            //no result o include está fazendo o join com a tabela Seller e Department e ordenando a consulta por Data
            return await result.Include(x => x.Seller).Include(x => x.Seller.Department).OrderByDescending(x => x.Date).ToListAsync();

        }
        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            //criando um query q vai ser executada pelo DBSET no banco de dados para retornar os dados
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                //criando a restrição de data minima caso minDate tenha sido preenchido
                result = result.Where(c => c.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                //criando a restrição de data minima caso minDate tenha sido preenchido
                result = result.Where(c => c.Date <= maxDate.Value);
            }
            //no result o include está fazendo o join com a tabela Seller e Department e ordenando a consulta por Data
            return await result.Include(x => x.Seller).Include(x => x.Seller.Department).OrderByDescending(x => x.Date).GroupBy(c => c.Seller.Department).ToListAsync();

        }

        public async Task<List<SalesRecord>> FindBySellerId(int id)
        {
            //criando um query q vai ser executada pelo DBSET no banco de dados para retornar os dados
            var result = from obj in _context.SalesRecord select obj;
            //no result o include está fazendo o join com a tabela Seller e Department e ordenando a consulta por Data
            return await result.Include(x => x.Seller).Include(x => x.Seller.Department).Where(x => x.Seller.Id == id).OrderByDescending(x => x.Date).ToListAsync();
        }

        public async Task<List<Seller>> GetAllSellersAsync()
        {
            return await _context.Seller.ToListAsync();
        }
    }
}
