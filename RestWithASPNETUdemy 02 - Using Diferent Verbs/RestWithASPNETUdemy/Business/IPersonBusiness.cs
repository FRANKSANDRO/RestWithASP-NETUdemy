using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {
        Persons Create(Persons person);
        Persons FindById(long id);
        List<Persons> FindAll();
        Persons Update(Persons person);
        void Delete(long id);
    }
}
