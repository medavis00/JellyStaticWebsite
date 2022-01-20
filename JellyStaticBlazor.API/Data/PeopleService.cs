using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JellyStaticBlazor.Common.Models;

namespace JellyStaticBlazor.API.Data
{
    public class PeopleService : IPeopleService
    {
        PersonsManager personsManager;
        
        public PeopleService(PersonsManager _personsManager)
        {
            personsManager = _personsManager;
        }

        public ValueTask<PeopleReply> GetAll(GetAllPeopleRequest request)
        {
            var reply = new PeopleReply();
            reply.People.AddRange(personsManager.People);
            return new ValueTask<PeopleReply>(reply);
        }

        public ValueTask<Person> GetPersonById(GetPersonByIdRequest request)
        {
            var result = (from x in personsManager.People
                          where x.Id == request.Id
                          select x).FirstOrDefault();
            return new ValueTask<Person>(result);
        }
    }
}
