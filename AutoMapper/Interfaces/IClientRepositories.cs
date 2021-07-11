using AutoMapper.Models;
using System.Collections.Generic;

namespace AutoMapperExample.Interfaces
{
    public interface IClientRepositories
    {
        IEnumerable<Client> GetAll();
    }
}
