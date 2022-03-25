using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using RestWithASP_NET5Udemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Business.Implementation
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        public PersonBusinessImplementation(IRepository<Person> repository) =>
            _repository = repository;

        public List<Person> FindAll() =>
            _repository.FindAll();

        public Person FindById(long id) =>
            _repository.FindById(id);

        public Person Create(Person person) =>
            _repository.Create(person);

        public void Delete(long id) =>
            _repository.Delete(id);


        public Person Update(Person person) =>
            _repository.Update(person);
    }
}
