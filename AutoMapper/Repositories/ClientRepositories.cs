using AutoMapper.Models;
using AutoMapperExample.Interfaces;
using System;
using System.Collections.Generic;

namespace AutoMapper.Repositories
{
    public class ClientRepositories : IClientRepositories
    {
        public IEnumerable<Client> GetAll()
        {
            List<Client> list = new List<Client>
            {
                new Client {Id = 1, Name = "Client1", BirthDate = Convert.ToDateTime("2000/01/10")},
                new Client {Id = 2, Name = "Client2", BirthDate = Convert.ToDateTime("1999/05/20")},
                new Client {Id = 3, Name = "Client3", BirthDate = Convert.ToDateTime("2001/09/07")},
                new Client {Id = 4, Name = "Client4", BirthDate = Convert.ToDateTime("1995/11/01")},
            };

            return list;
        }
    }
}
