using AutoMapper.Models;

namespace AutoMapper.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            //CreateMap<SourceType, DestinationType>();
            CreateMap<Client, Person>();
            CreateMap<Person, Client>();
        }
    }
}
