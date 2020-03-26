using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository
    {
        Persons Create(Persons person);
        Persons FindById(long id);
        List<Persons> FindAll();
        Persons Update(Persons person);
        void Delete(long id);

        bool Exist(long? id);
    }
}
