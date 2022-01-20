using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace JellyStaticBlazor.Common.Models
{
    [ServiceContract]
    public interface IPeopleService
    {
        ValueTask<PeopleReply> GetAll(GetAllPeopleRequest request);
        ValueTask<Person> GetPersonById(GetPersonByIdRequest request);
    }

}
