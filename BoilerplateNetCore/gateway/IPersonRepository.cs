using System.Collections.Generic;
using BoilerplateNetCore.domain.model;

namespace BoilerplateNetCore.gateway
{
    public interface IPersonRepository
    {
        List<Person> listPerson();
    }
}