using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Persons Create(Persons person);
        Persons FindById(long id);
        List<Persons> FindAll();
        Persons Update(Persons person);
        void Delete(long id);
    }
}
