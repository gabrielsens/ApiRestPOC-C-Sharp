using AR.Data.Interfaces;
using AR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Data.Implementation
{
    public class ClienteRepository : IClienteRepository
    {
        public Task Add(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
