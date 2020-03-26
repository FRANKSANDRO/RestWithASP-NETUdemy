using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;

        private volatile int count;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Persons Create(Persons person)
        {
            return _repository.Create(person);
        }

        public Persons Update(Persons person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Persons> FindAll()
        {
            return _repository.FindAll();
        }

        public Persons FindById(long id)
        {
            return _repository.FindById(id);
        }
    }
}
