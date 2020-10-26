using AcessarCep.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcessarCep.Interfaces
{
    public interface ICepService
    {
        public Task<Address> GetAddress(string cep);
    }
}
