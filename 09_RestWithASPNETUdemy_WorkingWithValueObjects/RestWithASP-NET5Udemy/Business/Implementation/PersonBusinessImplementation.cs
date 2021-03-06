using RestWithASP_NET5Udemy.Data.Converter.Implementations;
using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Repository;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Business.Implementation
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;
        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll() =>
            _converter.Parse(_repository.FindAll());

        public PersonVO FindById(long id) =>
            _converter.Parse(_repository.FindById(id));

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id) =>
            _repository.Delete(id);

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
    }
}
